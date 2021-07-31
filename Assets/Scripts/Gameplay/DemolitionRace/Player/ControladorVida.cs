using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControladorVida : MonoBehaviour
{
    int VidaACambiar;
    string objetoColision;

    VictoriaDerrota victoriaDerrota;

    public EstadoVehiculo causarDa�oP;
    public EstadoVehiculo causarDa�oE;

    void Start()
    {
        victoriaDerrota = GameObject.Find("RaceManager").GetComponent<VictoriaDerrota>();
    }

    public void CambiarVida(int VidaACambiar, string objetoColision)
    {
        if (objetoColision == "Player")
            causarDa�oP.vida += VidaACambiar;
           

        if (objetoColision =="Enemy")
            causarDa�oE.vida += VidaACambiar;

        victoriaDerrota.Vidas();

    }




}
