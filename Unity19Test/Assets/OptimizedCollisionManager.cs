using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class OptimizedCollisionManager : MonoBehaviour
{
    SerialPort serialPort;
    string portName = "COM5"; // Change this to your Arduino port
    int baudRate = 115200; // Match the Arduino baud rate

    ColScript[,] thumbCellCols = new ColScript[2, 8];
    ColScript[,] indexCellCols = new ColScript[2, 8];
    ColScript[,] middleCellCols = new ColScript[2, 8];
    ColScript[,] ringCellCols = new ColScript[2, 8];

    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);

        try
        {
            serialPort.Open();
            Debug.Log("Serial port opened successfully.");
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error opening serial port: {e.Message}");
        }

        InitializeColScripts("TCell1", thumbCellCols);
        InitializeColScripts("TCell2", thumbCellCols);
        InitializeColScripts("ICell1", indexCellCols);
        InitializeColScripts("ICell2", indexCellCols);
        InitializeColScripts("MCell1", middleCellCols);
        InitializeColScripts("MCell2", middleCellCols);
        InitializeColScripts("RCell1", ringCellCols);
        InitializeColScripts("RCell2", ringCellCols);

        Debug.Log("Initialized Successfully");
    }

    void Update()
    {
        string finalResult = GenerateFinalResult();
        if (!string.IsNullOrEmpty(finalResult))
        {
            //Debug.Log(finalResult);
            serialPort.Write("<" + finalResult + ">");
        }
    }

    void InitializeColScripts(string cellName, ColScript[,] cellCols)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                string objectName = $"{cellName}_{j + 1}";
                GameObject cellObject = GameObject.Find(objectName);

                if (cellObject != null)
                {
                    cellCols[i, j] = cellObject.GetComponent<ColScript>();
                    Debug.Log($"Initialized {objectName}");
                }
                else
                {
                    Debug.LogError($"GameObject {objectName} not found!");
                }
            }
        }
    }

    string GenerateFinalResult()
    {
        int[] thumbResults = GetCellResults(thumbCellCols);
        int[] indexResults = GetCellResults(indexCellCols);
        int[] middleResults = GetCellResults(middleCellCols);
        int[] ringResults = GetCellResults(ringCellCols);

        string finalResult = $"{thumbResults[0]:000}{thumbResults[1]:000}{indexResults[0]:000}{indexResults[1]:000}{middleResults[0]:000}{middleResults[1]:000}{ringResults[0]:000}{ringResults[1]:000}000000";

        return finalResult;
    }

    int[] GetCellResults(ColScript[,] cellCols)
    {
        int[] results = new int[2];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                results[i] += (cellCols[i, j] != null && cellCols[i, j].IsInContact()) ? (int)Mathf.Pow(2, j) : 0;
            }
        }

        return results;
    }

    void OnDestroy()
    {
        Debug.Log("Destroying script. Closing serial port.");
        CloseSerialPort();
    }

    void CloseSerialPort()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
            Debug.Log("Serial port closed successfully.");
        }
    }
}
