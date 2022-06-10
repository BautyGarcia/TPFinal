using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehave : MonoBehaviour
{
    public GameObject Canvas;
    public Text InputText;
    public static int CantRondas;
    public Text TimeText;
    int TotalTime = 30;
    float TimeLeft = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (TotalTime - Mathf.Floor(Time.time) >= 0)
        {
            TimeLeft = TotalTime - Mathf.Floor(Time.time);
            TimeText.text = TimeLeft.ToString();
        } else {
            return;
        }
        
    }

    public void CanvasSetActive()
    {
        if (InputText.text == ""){
            CantRondas = 3;
            Canvas.SetActive(false);
        } else {
            Canvas.SetActive(false);
            CantRondas = int.Parse(InputText.text);
        }

    }
}
