using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorVida : MonoBehaviour
{
    public EstadoVehiculo estadoVehiculoP;
    public EstadoVehiculo estadoVehiculoE;

    public bool VidaE = true;
    public bool VidaP = true;

    int da�o;
    float at, bt, ct;
    Vector3 c;

    private void FixedUpdate()
    {
        if (estadoVehiculoP.vida <= 0)
        {
            VidaP = false;
            //Destroy(estadoVehiculoP.gameObject);
        }

        if(estadoVehiculoE.vida <= 0)
        {
            VidaE = false;
            //Destroy(estadoVehiculoE.gameObject);
        }
    }
    void Start()
    {
    }

    public void CambiarVida(Vector3 a, Vector3 b, string objetoCollision, int attack)
    {
        at = a.magnitude;
        bt = b.magnitude;

        if (at > bt)
        {
            c = a - b;
            ct = c.magnitude;

            da�o = (int)ct * attack;

            if (objetoCollision == estadoVehiculoP.tag)
            {
                estadoVehiculoP.RecibirDa�o(da�o);
            }


            if (objetoCollision == estadoVehiculoE.name)
            {
                estadoVehiculoE.RecibirDa�o(da�o);
            }
        }
    }
}
