using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable_Taza : MonoBehaviour
{
      private static int contador = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InteractiveArea"))
        {
       contador++;
        Debug.Log("Tazas recolectadas: " + contador);
            Destroy(gameObject);
        }
    }
}
