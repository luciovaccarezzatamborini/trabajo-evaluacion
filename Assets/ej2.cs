using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej2 : MonoBehaviour
{
    public float edad;
    public float altura;
    // Start is called before the first frame update
    void Start()
    {
        if (edad < 1 || altura < 0)
        {
            Debug.Log("Error al ingresar la edad o la altura");

        }

        else if (altura > 1.2 || edad > 13)
        {
            Debug.Log("Tiene permitido el acceso");
        }

        else if (altura < 1.2 & edad < 13)

        {
            Debug.Log("Tiene denegado  el acceso");
        }












    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
