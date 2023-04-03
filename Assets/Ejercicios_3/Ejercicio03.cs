using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio03 : MonoBehaviour
{
    // Crear un script que genere un cubo al inicio y duplique su escala
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);

        GameObject Cubo = GameObject.Find("Cube");

        Cubo.transform.localScale = Vector3.one * 2f;
    }

}
