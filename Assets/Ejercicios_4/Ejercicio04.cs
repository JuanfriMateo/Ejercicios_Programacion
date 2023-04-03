using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    // Crear un script que genere una esfera al inicio con un Rigidbody añadido
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Sphere);

        GameObject Pelota = GameObject.Find("Sphere");

        Rigidbody body = Pelota.AddComponent<Rigidbody>();
    }

}
