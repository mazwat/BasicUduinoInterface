using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Uduino;


public class LedButton : MonoBehaviour
{
    public Button onButton;
    public Button offButton;
    // Start is called before the first frame update
    void Start()
    {
        UduinoManager.Instance.pinMode(6, PinMode.Output);
        Button onbtn = onButton.GetComponent<Button>();
        Button offbtn = offButton.GetComponent<Button>();
        onbtn.onClick.AddListener(TaskOnClickON);
        offbtn.onClick.AddListener(TaskOnClickOFF);
    }

    void TaskOnClickON()
    {
        //Debug.Log("You have clicked the button!");
        UduinoManager.Instance.digitalWrite(6, State.HIGH);
    }
    void TaskOnClickOFF()
    {
        //Debug.Log("You have clicked the button!");
        UduinoManager.Instance.digitalWrite(6, State.LOW);
    }
}


