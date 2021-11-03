using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class EstadoVehiculo : MonoBehaviour
{
    ControladorVida contadorVida;
    [SerializeField] Slider slider;
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
        rb = GetComponent<Rigidbody>(); 
    }
    private void Start()
    {
        vida = 100;
        Estados.ModificarEstado("gameOver", false);
    }
    private void Update()
    {
       cartelDa�o();
    }

    void OnCollisionEnter(Collision other)
    {
        speedV3 = rb.velocity;

        if (other.gameObject.tag == "Player")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.tag, attack);


        if (other.gameObject.tag == "Enemy")
            contadorVida.CambiarVida(speedV3, other.rigidbody.velocity, other.collider.name, attack);

        Debug.Log("Vida de " +this.name +": "+ vida);
    }

    public void RecibirDa�o(int da�o)
    {
        vida -= da�o;
        slider.value = vida;
        text.text = "" + -da�o;
        tiempoDa�o = esperaDa�o;
    }

    void cartelDa�o()
    {
        if (tiempoDa�o > 0) 
        { 
            tiempoDa�o -= Time.deltaTime;

            if (tiempoDa�o <= 0)
                text.text = "";
        }
    }
}
