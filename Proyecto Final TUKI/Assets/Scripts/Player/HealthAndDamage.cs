using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthAndDamage : MonoBehaviour
{
    public int vida = 100;
    public Slider barraVitalidad;

    //public int vitalidad = 100;

    void Update()
    {
        //barraVitalidad.value=vitalidad;
        barraVitalidad.GetComponent<Slider>().value = vida;
        if (vida <= 0)
        {
            Debug.Log("GAME OVER");
            AudioManager.instance.Play("Derrota"); //Ejecuta Audio
            SceneManager.LoadScene(0);

        }
    }

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
        
    }
    
   
}
