using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio08 : MonoBehaviour
{
    // Crear un script que genere tres cubos cada uno el doble de grande que el anterior
    void Start()
    {
        GameObject cubo1 = GameObject.CreatePrimitive(PrimitiveType.Cube);

        GameObject cubo2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo2.transform.localScale = cubo1.transform.localScale * 2;

        GameObject cubo3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubo3.transform.localScale = cubo2.transform.localScale * 2;
    }
}
