using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable_Taza : MonoBehaviour
{
private Score_Manager scoreManager;

    void Start()
    {
    scoreManager = FindObjectOfType<Score_Manager>();

    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InteractiveArea"))
        {
            scoreManager.AddScore();
            Destroy(gameObject);
        }
    }
}