using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoriaDerrota : MonoBehaviour
{

    CausarDa�o causarDa�oP;
    CausarDa�o causarDa�oE;

    Checkpoints meta;

    public string CheckpointInfo;

    void Start()
    {
        causarDa�oP = GameObject.Find("Player").GetComponent<CausarDa�o>();
        causarDa�oE = GameObject.Find("Enemy").GetComponent<CausarDa�o>();

        meta = GameObject.Find("Meta").GetComponent<Checkpoints>();
    }

 
    void Update()
    {
        if (causarDa�oP.vida <= 0)
            Debug.Log("Derrota");

        if (causarDa�oE.vida <= 0)
            Debug.Log("Victoria");
    }
   public void Checkpoints(string CheckpointInfo)
    {
        Debug.Log("meta");
        if (CheckpointInfo == "Player")
            Debug.Log("meta");

    }

}
