using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using UnityEngine.UI;

public class ReadAnalogue : MonoBehaviour
{
    public Text sensorText;
    public Image panel;
    public int Mapped;
    // Start is called before the first frame update
    void Start()
    {
        //sensorText = GetComponent<Text>();
        UduinoManager.Instance.pinMode(AnalogPin.A0, PinMode.Input);
        //panel = GetComponent<Image>();//Pin mode in analog to enable reading

    }

    // Update is called once per frame
    void Update()
    {
       int readValue = UduinoManager.Instance.analogRead(AnalogPin.A0);
       //Debug.Log("Photo: " + readValue.ToString());
       int valueMapped = Mathf.FloorToInt(Remap(readValue, 380, 750, 1, 255));
       sensorText.text = "Sensor Input: " + readValue.ToString();
        Mapped = valueMapped;

        panel.color = new Color32((byte)valueMapped, (byte)valueMapped, (byte)valueMapped, 255);

    }

    float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        var fromAbs = from - fromMin;
        var fromMaxAbs = fromMax - fromMin;

        var normal = fromAbs / fromMaxAbs;

        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;

        var to = toAbs + toMin;

        return to;
    }

}