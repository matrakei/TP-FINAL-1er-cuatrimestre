using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArraysObjetos : MonoBehaviour
{
    public GameObject[] Objetos; // Arreglo de objetos
    private int objetosIndex = 0; // Índice del objeto activo

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNextLight();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePreviousLight();
        }
    }

    public void ActivateNextLight()
    {
        objetosIndex++;
        if (objetosIndex >= Objetos.Length)
        {
            objetosIndex = 0;
        }
        DeactivateAllLights();
        Objetos[objetosIndex].SetActive(true);
    }

    public void ActivatePreviousLight()
    {
        objetosIndex--;
        if (objetosIndex < 0)
        {
            objetosIndex = Objetos.Length - 1;
        }
        DeactivateAllLights();
        Objetos[objetosIndex].SetActive(true);
    }

    void DeactivateAllLights()
    {
        foreach (GameObject g in Objetos)
        {
            g.SetActive(false);
        }
    }


    public void ActivateRepeating(float t)
    {

    }
}
