using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlotaDeTaxis : MonoBehaviour
{
    public int cantidadTaxis;
    public int diasTrabajados;
    float descuento100Litros = 0.2f;
    int KilometrosPorDia = 90;
    int kilometrosPorLitro = 15;
    float PrecioCombustibleLitro = 130;
    float litrosDeCombustible;
    float precioTotal;

    void Start()
    {
        if (diasTrabajados < 5)
        {
            Debug.Log("ERROR, la cantidad minima de dias para calcular tiene que ser al menos de 5.");
            return;
        }
        else
        {
            if (cantidadTaxis < 1)
            {
                Debug.Log("ERROR, la cantidad minima de taxis para calcular es de al menos 1.");
                return;
            }
            else
            {
                litrosDeCombustible = cantidadTaxis * (KilometrosPorDia / kilometrosPorLitro);
                litrosDeCombustible *= diasTrabajados;

                if (litrosDeCombustible > 100)
                {
                    precioTotal = litrosDeCombustible * PrecioCombustibleLitro;
                    precioTotal -= precioTotal * descuento100Litros;
                    Debug.Log("Una flota de " + cantidadTaxis + " unidades trabajando durante " + diasTrabajados + " días implicará un gasto de " + precioTotal + " pesos en concepto de combustible. Ha aplicado un descuento del 20% ya que compro mas de 100 litros de combustible.");
                    return;
                }
                else
                {
                    precioTotal = litrosDeCombustible * PrecioCombustibleLitro;
                    Debug.Log("Una flota de " + cantidadTaxis + " unidades trabajando durante " + diasTrabajados + " días implicará un gasto de " + precioTotal + " pesos en concepto de combustible.");
                    return;
                }
            }

        }
    }
}
