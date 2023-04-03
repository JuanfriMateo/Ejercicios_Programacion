using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio06 : MonoBehaviour
{
    // Crear un script que genere dos esferas al inicio separadas 100 metros
    void Start()
    {
        GameObject es1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        GameObject es2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        es2.transform.position = new Vector3(0f, 0f, 100f);
    }

}
