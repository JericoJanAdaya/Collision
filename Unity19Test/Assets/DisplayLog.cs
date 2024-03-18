using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class DisplayLog : MonoBehaviour
{
    SerialPort serialPort;
    string portName = "COM10"; // Change this to your Arduino port
    int baudRate = 9600; // Match the Arduino baud rate

    /*ColScript colScript1;
    ColScript colScript2;
    ColScript colScript3;
    ColScript colScript4;*/

    ColScript colScript_TCell1_1;
    ColScript colScript_TCell1_2;
    ColScript colScript_TCell1_3;
    ColScript colScript_TCell1_4;
    ColScript colScript_TCell1_5;
    ColScript colScript_TCell1_6;
    ColScript colScript_TCell1_7;
    ColScript colScript_TCell1_8;

    ColScript colScript_TCell2_1;
    ColScript colScript_TCell2_2;
    ColScript colScript_TCell2_3;
    ColScript colScript_TCell2_4;
    ColScript colScript_TCell2_5;
    ColScript colScript_TCell2_6;
    ColScript colScript_TCell2_7;
    ColScript colScript_TCell2_8;

    ColScript colScript_ICell1_1;
    ColScript colScript_ICell1_2;
    ColScript colScript_ICell1_3;
    ColScript colScript_ICell1_4;
    ColScript colScript_ICell1_5;
    ColScript colScript_ICell1_6;
    ColScript colScript_ICell1_7;
    ColScript colScript_ICell1_8;

    ColScript colScript_ICell2_1;
    ColScript colScript_ICell2_2;
    ColScript colScript_ICell2_3;
    ColScript colScript_ICell2_4;
    ColScript colScript_ICell2_5;
    ColScript colScript_ICell2_6;
    ColScript colScript_ICell2_7;
    ColScript colScript_ICell2_8;


    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);
        serialPort.Open();

        /*GameObject Cube_1 = GameObject.Find("Cube_1"); // Find the GameObject with ColScript
        GameObject Cube_2 = GameObject.Find("Cube_2");
        GameObject Cube_3 = GameObject.Find("Cube_3");
        GameObject Cube_4 = GameObject.Find("Cube_4");

        colScript1 = Cube_1.GetComponent<ColScript>();
        colScript2 = Cube_2.GetComponent<ColScript>();
        colScript3 = Cube_3.GetComponent<ColScript>();
        colScript4 = Cube_4.GetComponent<ColScript>();*/


        GameObject TCell1_1 = GameObject.Find("TCell1_1");
        GameObject TCell1_2 = GameObject.Find("TCell1_2");
        GameObject TCell1_3 = GameObject.Find("TCell1_3");
        GameObject TCell1_4 = GameObject.Find("TCell1_4");
        GameObject TCell1_5 = GameObject.Find("TCell1_5");
        GameObject TCell1_6 = GameObject.Find("TCell1_6");
        GameObject TCell1_7 = GameObject.Find("TCell1_7");
        GameObject TCell1_8 = GameObject.Find("TCell1_8");

        GameObject TCell2_1 = GameObject.Find("TCell2_1");
        GameObject TCell2_2 = GameObject.Find("TCell2_2");
        GameObject TCell2_3 = GameObject.Find("TCell2_3");
        GameObject TCell2_4 = GameObject.Find("TCell2_4");
        GameObject TCell2_5 = GameObject.Find("TCell2_5");
        GameObject TCell2_6 = GameObject.Find("TCell2_6");
        GameObject TCell2_7 = GameObject.Find("TCell2_7");
        GameObject TCell2_8 = GameObject.Find("TCell2_8");

        GameObject ICell1_1 = GameObject.Find("ICell1_1");
        GameObject ICell1_2 = GameObject.Find("ICell1_2");
        GameObject ICell1_3 = GameObject.Find("ICell1_3");
        GameObject ICell1_4 = GameObject.Find("ICell1_4");
        GameObject ICell1_5 = GameObject.Find("ICell1_5");
        GameObject ICell1_6 = GameObject.Find("ICell1_6");
        GameObject ICell1_7 = GameObject.Find("ICell1_7");
        GameObject ICell1_8 = GameObject.Find("ICell1_8");

        GameObject ICell2_1 = GameObject.Find("ICell2_1");
        GameObject ICell2_2 = GameObject.Find("ICell2_2");
        GameObject ICell2_3 = GameObject.Find("ICell2_3");
        GameObject ICell2_4 = GameObject.Find("ICell2_4");
        GameObject ICell2_5 = GameObject.Find("ICell2_5");
        GameObject ICell2_6 = GameObject.Find("ICell2_6");
        GameObject ICell2_7 = GameObject.Find("ICell2_7");
        GameObject ICell2_8 = GameObject.Find("ICell2_8");



        colScript_TCell1_1 = TCell1_1.GetComponent<ColScript>();
        colScript_TCell1_2 = TCell1_2.GetComponent<ColScript>();
        colScript_TCell1_3 = TCell1_3.GetComponent<ColScript>();
        colScript_TCell1_4 = TCell1_4.GetComponent<ColScript>();
        colScript_TCell1_5 = TCell1_5.GetComponent<ColScript>();
        colScript_TCell1_6 = TCell1_6.GetComponent<ColScript>();
        colScript_TCell1_7 = TCell1_7.GetComponent<ColScript>();
        colScript_TCell1_8 = TCell1_8.GetComponent<ColScript>();

        colScript_TCell2_1 = TCell2_1.GetComponent<ColScript>();
        colScript_TCell2_2 = TCell2_2.GetComponent<ColScript>();
        colScript_TCell2_3 = TCell2_3.GetComponent<ColScript>();
        colScript_TCell2_4 = TCell2_4.GetComponent<ColScript>();
        colScript_TCell2_5 = TCell2_5.GetComponent<ColScript>();
        colScript_TCell2_6 = TCell2_6.GetComponent<ColScript>();
        colScript_TCell2_7 = TCell2_7.GetComponent<ColScript>();
        colScript_TCell2_8 = TCell2_8.GetComponent<ColScript>();

        colScript_ICell1_1 = ICell1_1.GetComponent<ColScript>();
        colScript_ICell1_2 = ICell1_2.GetComponent<ColScript>();
        colScript_ICell1_3 = ICell1_3.GetComponent<ColScript>();
        colScript_ICell1_4 = ICell1_4.GetComponent<ColScript>();
        colScript_ICell1_5 = ICell1_5.GetComponent<ColScript>();
        colScript_ICell1_6 = ICell1_6.GetComponent<ColScript>();
        colScript_ICell1_7 = ICell1_7.GetComponent<ColScript>();
        colScript_ICell1_8 = ICell1_8.GetComponent<ColScript>();

        colScript_ICell2_1 = ICell2_1.GetComponent<ColScript>();
        colScript_ICell2_2 = ICell2_2.GetComponent<ColScript>();
        colScript_ICell2_3 = ICell2_3.GetComponent<ColScript>();
        colScript_ICell2_4 = ICell2_4.GetComponent<ColScript>();
        colScript_ICell2_5 = ICell2_5.GetComponent<ColScript>();
        colScript_ICell2_6 = ICell2_6.GetComponent<ColScript>();
        colScript_ICell2_7 = ICell2_7.GetComponent<ColScript>();
        colScript_ICell2_8 = ICell2_8.GetComponent<ColScript>();

        Debug.Log("Initialized Succesfully");

    }

    void Update()
    {
        string finalResult = GenerateFinalResult();
        if (!string.IsNullOrEmpty(finalResult))
        {
            serialPort.Write("<"+finalResult+">");
        }
    }

    string GenerateFinalResult()
    {
        /*int result1 = colScript1 != null && colScript1.IsInContact() ? 27 : 0;
        int result2 = colScript2 != null && colScript2.IsInContact() ? 27 : 0;
        int result3 = colScript3 != null && colScript3.IsInContact() ? 228 : 0;
        int result4 = colScript4 != null && colScript4.IsInContact() ? 228 : 0; */

        int Tresult01 = colScript_TCell1_1 != null && colScript_TCell1_1.IsInContact() ? 1 : 0;
        int Tresult02 = colScript_TCell1_2 != null && colScript_TCell1_2.IsInContact() ? 8 : 0;
        int Tresult03 = colScript_TCell1_3 != null && colScript_TCell1_3.IsInContact() ? 2 : 0;
        int Tresult04 = colScript_TCell1_4 != null && colScript_TCell1_4.IsInContact() ? 16 : 0;
        int Tresult05 = colScript_TCell1_5 != null && colScript_TCell1_5.IsInContact() ? 4 : 0;
        int Tresult06 = colScript_TCell1_6 != null && colScript_TCell1_6.IsInContact() ? 32 : 0;
        int Tresult07 = colScript_TCell1_7 != null && colScript_TCell1_7.IsInContact() ? 64 : 0;
        int Tresult08 = colScript_TCell1_8 != null && colScript_TCell1_8.IsInContact() ? 128 : 0;

        int Tresult09 = colScript_TCell2_1 != null && colScript_TCell2_1.IsInContact() ? 1 : 0;
        int Tresult10 = colScript_TCell2_2 != null && colScript_TCell2_2.IsInContact() ? 8 : 0;
        int Tresult11 = colScript_TCell2_3 != null && colScript_TCell2_3.IsInContact() ? 2 : 0;
        int Tresult12 = colScript_TCell2_4 != null && colScript_TCell2_4.IsInContact() ? 16 : 0;
        int Tresult13 = colScript_TCell2_5 != null && colScript_TCell2_5.IsInContact() ? 4 : 0;
        int Tresult14 = colScript_TCell2_6 != null && colScript_TCell2_6.IsInContact() ? 32 : 0;
        int Tresult15 = colScript_TCell2_7 != null && colScript_TCell2_7.IsInContact() ? 64 : 0;
        int Tresult16 = colScript_TCell2_8 != null && colScript_TCell2_8.IsInContact() ? 128 : 0;

        int Iresult01 = colScript_ICell1_1 != null && colScript_ICell1_1.IsInContact() ? 1 : 0;
        int Iresult02 = colScript_ICell1_2 != null && colScript_ICell1_2.IsInContact() ? 8 : 0;
        int Iresult03 = colScript_ICell1_3 != null && colScript_ICell1_3.IsInContact() ? 2 : 0;
        int Iresult04 = colScript_ICell1_4 != null && colScript_ICell1_4.IsInContact() ? 16 : 0;
        int Iresult05 = colScript_ICell1_5 != null && colScript_ICell1_5.IsInContact() ? 4 : 0;
        int Iresult06 = colScript_ICell1_6 != null && colScript_ICell1_6.IsInContact() ? 32 : 0;
        int Iresult07 = colScript_ICell1_7 != null && colScript_ICell1_7.IsInContact() ? 64 : 0;
        int Iresult08 = colScript_ICell1_8 != null && colScript_ICell1_8.IsInContact() ? 128 : 0;

        int Iresult09 = colScript_ICell2_1 != null && colScript_ICell2_1.IsInContact() ? 1 : 0;
        int Iresult10 = colScript_ICell2_2 != null && colScript_ICell2_2.IsInContact() ? 8 : 0;
        int Iresult11 = colScript_ICell2_3 != null && colScript_ICell2_3.IsInContact() ? 2 : 0;
        int Iresult12 = colScript_ICell2_4 != null && colScript_ICell2_4.IsInContact() ? 16 : 0;
        int Iresult13 = colScript_ICell2_5 != null && colScript_ICell2_5.IsInContact() ? 4 : 0;
        int Iresult14 = colScript_ICell2_6 != null && colScript_ICell2_6.IsInContact() ? 32 : 0;
        int Iresult15 = colScript_ICell2_7 != null && colScript_ICell2_7.IsInContact() ? 64 : 0;
        int Iresult16 = colScript_ICell2_8 != null && colScript_ICell2_8.IsInContact() ? 128 : 0;

        //int rescomp1 = result1 + result3;
        //int rescomp2 = result2 + result4;

        int ThumbCell1Comp = Tresult01 + Tresult02 + Tresult03 + Tresult04 + Tresult05 + Tresult06 + Tresult07 + Tresult08;
        int ThumbCell2Comp = Tresult09 + Tresult10 + Tresult11 + Tresult12 + Tresult13 + Tresult14 + Tresult15 + Tresult16;

        int IndexCell1Comp = Iresult01 + Iresult02 + Iresult03 + Iresult04 + Iresult05 + Iresult06 + Iresult07 + Iresult08;
        int IndexCell2Comp = Iresult09 + Iresult10 + Iresult11 + Iresult12 + Iresult13 + Iresult14 + Iresult15 + Iresult16;

        //string formattedResult1 = rescomp1.ToString("000");
        //string formattedResult2 = rescomp2.ToString("000");

        string TformattedResult1 = ThumbCell1Comp.ToString("000");
        string TformattedResult2 = ThumbCell2Comp.ToString("000");
        string IformattedResult1 = IndexCell1Comp.ToString("000");
        string IformattedResult2 = IndexCell2Comp.ToString("000");


        string finalResult = TformattedResult1 + TformattedResult2 + IformattedResult1 + IformattedResult2;

        return finalResult;
    }

    void OnDestroy()
    {
        CloseSerialPort();
    }

    void CloseSerialPort()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}