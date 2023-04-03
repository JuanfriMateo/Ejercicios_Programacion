using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    // Crear un script que genere tres esferas al inicio separadas 100 metros
    void Start()
    {
        GameObject es1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        GameObject es2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        es2.transform.position = es1.transform.position + new Vector3(0f, 0f, 100f);

        GameObject es3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        es3.transform.position = es2.transform.position + new Vector3(0f, 0f, 100f);
    }

}
