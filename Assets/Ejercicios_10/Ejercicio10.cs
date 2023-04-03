using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio10 : MonoBehaviour
{
    // Crear un script que cambie el nombre de todos los GameObjects de la escena en base a un atributo definido en este
    void Start()
    {
        GameObject[] objetos = GameObject.FindObjectsOfType<GameObject>();

        foreach (GameObject obj in objetos)
        {
            obj.name = "nombredefault";
        }
    }
}
