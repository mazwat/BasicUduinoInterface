using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;
using UnityEngine.UI;

public class FadeLED : MonoBehaviour
{
    
    [Range(0, 255)]
    public int intensity = 0;
    public Slider sliderUI;
    // Start is called before the first frame update
    void Start()
    {
        UduinoManager.Instance.pinMode(11, PinMode.Output);
    }

    // Update is called once per frame
    void Update()
    {
        intensity = (int)sliderUI.value;
        UduinoManager.Instance.analogWrite(11, intensity);
    }
}
