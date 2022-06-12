using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehave : MonoBehaviour
{
    public GameObject Canvas;
    public Text InputText;
    public static int CantRondas;
    public static bool GameStart = false;
    public Text TimeText;
    int TotalTime = 10;
    float TimeLeft = 0;
    public AudioManager miAM;
    public GameObject cubo;
    GameObject clon;

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
            CantRondas = 3;
            Canvas.SetActive(false);
            GameStart = true;
            miAM.PlayTheme();
        }
        
    }

    public void CanvasSetActive()
    {
        if (InputText.text == ""){
            CantRondas = 3;
            Canvas.SetActive(false);
            GameStart = true;
            miAM.PlayTheme();
        } else {
            Canvas.SetActive(false);
            CantRondas = int.Parse(InputText.text);
            GameStart = true;
            miAM.PlayTheme();
        }

    }

    public void Celebration(){
        for (int i = 0; i < 30; i++){
            clon = Instantiate(cubo);
            Destroy(clon,5);
        }
    }
}
