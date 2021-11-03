using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;
    [SerializeField] TextMeshProUGUI text;

    Rigidbody rb;

    public int vida;
    public int attack = 2;
    float tiempoDa�o;
    [SerializeField] float esperaDa�o = 1;
    [HideInInspector]public Vector3 speedV3;

    void Awake()
    {
        contadorVida = GameObject.Find("LifeController").GetComponent<ControladorVida>();
        if(this.gameObject.tag == "Player")
            text = GameObject.Find("NumeroDa�o").GetComponent<TextMeshProUGUI>();
        else
            this.text = GameObject.Find("NumeroDa�oEnemigo").GetComponent<TextMeshProUGUI>();
        rb = GetComponent<Rigidbody>(); 
    }
    private void Start()
    {
        this.vida = 100;
        Estados.ModificarEstado("gameOver", false);
    }
    private void Update()
    {
       cartelDa�o();
    }

    void OnCollisionEnter(Collision other)
    {
        this.speedV3 = this.rb.velocity;

        if (other.gameObject.tag == "Player")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.tag, this.attack);


        if (other.gameObject.tag == "Enemy")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.name, this.attack);

        Debug.Log("Vida de " +this.name +": "+ this.vida);
    }

    public void RecibirDa�o(int da�o)
    {
        this.vida -= da�o;
        this.text.text = "" + -da�o;
        this.tiempoDa�o = this.esperaDa�o;
    }

    void cartelDa�o()
    {
        if (this.tiempoDa�o > 0) 
        {
            this.tiempoDa�o -= Time.deltaTime;

            if (this.tiempoDa�o <= 0)
                this.text.text = "";
        }
    }
}
