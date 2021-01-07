using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using UnityEngine.UI;

public class ControlServo : MonoBehaviour
{
    public int servoPin = 3;
    [Range(0, 255)]
    //public int servoAngle = 0;
    public int angle;
    //private int prevServoAngle = 0;
    public Slider sliderUI;
    //public float angleF;

    void Start()
    {
        UduinoManager.Instance.pinMode(servoPin, PinMode.Servo);
    }

    void Update()
    {
        //UduinoManager.Instance.analogWrite(servoPin, angle); // Using slider in inspector
        angle = (int)sliderUI.value;
        UduinoManager.Instance.analogWrite(servoPin, angle); // Using slider in UI
        //Debug.Log("Slider: " + sliderUI.value);
    }
}
