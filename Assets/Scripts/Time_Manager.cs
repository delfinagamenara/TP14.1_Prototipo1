using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class Time_Manager : MonoBehaviour
{
    public float timer = 60f;
    private UI_Manager uiManager;
    public bool juegoTerminado = false;

    void Start()
    {
        uiManager = FindObjectOfType<UI_Manager>();
        Time.timeScale = 1;
    }

    void Update()
    {

        if (!juegoTerminado){
        if (timer > 0)
        
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }
        else
        {
            timer = 0;
            uiManager.UpdateTimer(0);
             juegoTerminado = true;
             uiManager.MostrarPantallaGameOver();  
            Time.timeScale = 0; 
            Debug.Log("¡Tiempo terminado!");
        }}
    
     if (juegoTerminado && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        } 
}}
