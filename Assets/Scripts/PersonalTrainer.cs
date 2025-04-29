using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonalTrainer : MonoBehaviour
{
    public string tipoServicio;
    public float cantHoras;

    int precioCardio = 1000;
    int precioFuerza = 1500;
    int precioRecreativo = 2500;

    float precioTotal = 0f;
    float precioDescuento = 0f;

    int maxHoras = 6;

    // Start is called before the first frame update
    void Start()
    {

        if (tipoServicio != "Cardio" && tipoServicio != "Fuerza" && tipoServicio != "Recreativo")
        {
            Debug.Log("Error al ingresar servicio.");
            return;
        }
        else if (cantHoras < 1 || cantHoras > maxHoras)
        {
            Debug.Log("Error al ingresar horas.");
            return;
        }
        else if (tipoServicio == "Cardio")
        {
            precioTotal = cantHoras * precioCardio;
        }
        else if (tipoServicio == "Fuerza")
        {
            precioTotal = cantHoras * precioFuerza;
        }
        else if (tipoServicio == "Recreativo")
        {
            precioTotal = cantHoras * precioRecreativo;
        }

        if (cantHoras == 6)
        {
            precioDescuento = precioTotal * 0.9f;
        }
        else
        {
            precioDescuento = precioTotal;
        }

        Debug.Log("- Tipo de entrenamiento: " + tipoServicio);
        Debug.Log("- Horas reservadas: " + cantHoras);
        Debug.Log("- Precio sin descuento: " + precioTotal);
        Debug.Log("- Precio con descuento si aplica: " + precioDescuento);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
