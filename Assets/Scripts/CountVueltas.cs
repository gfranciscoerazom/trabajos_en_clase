using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountVueltas : MonoBehaviour
{
    public int contador = 0;
    private bool isTouching = false;
    public TextMeshProUGUI contadorText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Cube" && !isTouching)
        {
            isTouching = true;
            contador++;

            // Cambia el texto "Contador" que está en el objeto Canvas
            contadorText.text = "Contador: " + contador;
            Debug.Log("El objeto Cube ha tocado a Cube (1). Contador: " + contador);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            isTouching = false;
        }
    }
}
