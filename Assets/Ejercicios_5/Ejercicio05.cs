using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    // Crear un script que genere 30 GameObjects al inicio
    void Start()
    {
        for(int i = 0; i < 30; i++)
        {
            GameObject go1 = new GameObject();
        }
    }
}
