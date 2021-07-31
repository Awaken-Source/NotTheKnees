using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ContadorVida : MonoBehaviour
{
    public int VidaACambiar;
    public string objetoColision;
  
    CausarDa�o causarDa�oP;
    CausarDa�o causarDa�oE;

    void Start()
    {
        causarDa�oP = GameObject.Find("Player").GetComponent<CausarDa�o>();
        causarDa�oE = GameObject.Find("Enemy").GetComponent<CausarDa�o>();

    }

    public void CambiarVida(int VidaACambiar, string objetoColision)
    {
        if (objetoColision == "Player")
            causarDa�oP.ControlVida(VidaACambiar);

        if (objetoColision =="Enemy")
            causarDa�oE.ControlVida(VidaACambiar);

       
       
    }

  

    private void Update()
    {
       
    }



}
