using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    public CausarDa�o causarDa�oP;
    public CausarDa�o causarDa�oE;

    public Checkpoints meta;
    public Checkpoints checkpoint1;

    public string CheckpointInfo;

    void Start()
    {
        
    }
    public void Vidas()
    {
        if (causarDa�oP.vida <= 0)
            Debug.Log("Derrota");

        if (causarDa�oE.vida <= 0)
            Debug.Log("Victoria");
    }
   public void Checkpoints(string CheckpointInfo)
    {
        if (CheckpointInfo == "Player")
            Debug.Log("meta");

    }
}
