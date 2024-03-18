using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;


public class testscript : MonoBehaviour
{
    SerialPort serialPort;
    string portName = "COM6"; // Change this to your Arduino port
    int baudRate = 9600; // Match the Arduino baud rate

    bool isInContact = false;

    void Start()
    {
        serialPort = new SerialPort(portName, baudRate);
        serialPort.Open();
    }

    void OnCollisionEnter(UnityEngine.Collision col)
    {
        if (col.gameObject.tag == "Object")
        { // Replace "YourTag" with the tag of the objects you want to detect collision with
            isInContact = true;
            SendSerialCommand();
        }
    }

    void OnCollisionExit(UnityEngine.Collision col)
    {
        if (col.gameObject.tag == "Object")
        {
            isInContact = false;
            SendSerialCommand();
        }
    }

    void OnDestroy()
    {
        CloseSerialPort(); // Close the serial port when the script is destroyed
    }

    void SendSerialCommand()
    {
        string command = isInContact ? "<255255>" : "<0>";
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Write(command);
        }
    }

    void CloseSerialPort()
    {
        if (serialPort != null && serialPort.IsOpen)
        {
            serialPort.Close();
        }
    }
}