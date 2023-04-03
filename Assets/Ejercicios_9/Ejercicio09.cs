using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    // Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    void Start()
    {
        Vector3 escala = new Vector3(1f, 1f, 1f);
        for (int i = 0; i < 12; i++)
        {
            GameObject bola = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            escala = escala * 2;
            bola.transform.localScale = escala;
        }
    }

}
