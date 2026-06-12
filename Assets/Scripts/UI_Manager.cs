using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject Panel_Ganaste;   
    public GameObject Panel_Perdiste;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float timer)
    {
        timerText.text = "00:" + Mathf.CeilToInt(timer).ToString("00");
    
    }

    public void MostrarPantallaWin()
    {
        Panel_Ganaste.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        Panel_Perdiste.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
