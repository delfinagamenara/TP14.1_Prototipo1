using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager : MonoBehaviour
{
    public float timer = 60f;
    private UI_Manager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UI_Manager>();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            uiManager.UpdateTimer(timer);
        }
        else
        {
            timer = 0;
            uiManager.UpdateTimer(0);
            Debug.Log("¡Tiempo terminado!");
        }
    }
}
