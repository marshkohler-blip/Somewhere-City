using UnityEngine;
using System.IO.Ports;

public class Connection : MonoBehaviour
{
    private SerialPort serial;

    void Start()
    {
        serial = new SerialPort("COM3", 9600);

        serial.ReadTimeout = 50;
        serial.DtrEnable = true;

        try
        {
            serial.Open();
            Debug.Log("Arduino connected!");
        }
        catch (System.Exception e)
        {
            Debug.LogError(e.Message);
        }
    }

    void Update()
    {
        if (serial != null && serial.IsOpen)
        {
            try
            {
                string data = serial.ReadExisting();

                if (!string.IsNullOrEmpty(data))
                {
                    if(!data.Equals("0")){
                        Debug.Log(data);}
                }
            }
            catch (System.Exception e)
            {
                Debug.LogWarning(e.Message);
            }
        }
    }

    void OnApplicationQuit()
    {
        if (serial != null && serial.IsOpen)
        {
            serial.Close();
        }
    }
}