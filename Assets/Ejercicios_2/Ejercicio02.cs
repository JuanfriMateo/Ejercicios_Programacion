using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    // Crear un script que genere un GameObject al inicio y trasladarlo a la posicion (111.1, -5, 4.5)
    void Start()
    {
        GameObject go2 = new GameObject("Ejercicio02");
        go2.transform.position = new Vector3(111.1f, -5f, 4.5f);
    }

}
