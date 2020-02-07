using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SerialPort port1 = new SerialPort("COM0", 9600);
        SerialPort bluetooth = new SerialPort("COM1", 38400);
    }

    // Update is called once per frame
    void Update()
    {
        if(port1.Read())
        {
            Debug.Log("Data: " + port1.Read());
        }
        
    }
}
