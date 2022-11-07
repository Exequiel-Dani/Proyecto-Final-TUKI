using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthAndDamage : MonoBehaviour
{
    public int vida = 100;
    public Slider vidaVisual;
    public Transform posicionInicial;
    public int intentos = 3;

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
        CheckHealth();


        /*if (vida <= 0)
        {
            GetComponent<Playermov>().enabled = false;
            gameObject.transform.position = startposition.position;
            GetComponent<Playermov>().enabled = true;


        }*/
    }
    public void CheckHealth()
    {
        if (vida <= 0)
        {
            Debug.Log("has muerto");
            intentos -= 1;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            transform.position = posicionInicial.position;
            Debug.Log("te quedan " + intentos + " intentos");
            vida = 100;
        }
        if (intentos <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vida;
        
    }
}
