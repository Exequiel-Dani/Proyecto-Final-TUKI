using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* vida enemigo*/ 
public class VidaEnemigoZ : MonoBehaviour
{
    /* Variables */
    private int vitalidad=100;
    public Animator animator;

    public int cantidadDanio;

    public Slider barraVitalidad;
    
    void Update(){
        barraVitalidad.GetComponent<Slider>().value = vitalidad; //actualiza la barra de vitalidad según el valor de vitalidad
    }

    /*  Función de recibir daño */
    public void RecibirDanio(int cantidadDanio)
    {
        vitalidad -= cantidadDanio; //resta la cantidad de daño a la vitalidad
        
        if(vitalidad<=0) //si el enemigo pierde toda la vitalidad
        {
            AudioManager.instance.Play("Muerte"); //Ejecuta Audio
            animator.SetTrigger("muerto"); //animación de muerte
            GetComponent<Collider>().enabled=false; //desactivación de colisionador
        }
        else
        {
            AudioManager.instance.Play("Herido");
            animator.SetTrigger("herido"); //animación de herida
            

        }
    }
 
}
