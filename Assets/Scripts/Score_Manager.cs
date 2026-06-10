using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
        private int score = 0;
        public int scoreMaximo = 5;
    private UI_Manager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<UI_Manager>();
    }
        public void AddScore()
    {
        score++;
        uiManager.UpdateScore(score);
        Debug.Log("Tazas recolectadas: " + score);
    
            if (score >= scoreMaximo)
        {
            uiManager.MostrarPantallaWin();
            Time.timeScale = 0;
            Debug.Log("¡Ganaste!");
        }}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
