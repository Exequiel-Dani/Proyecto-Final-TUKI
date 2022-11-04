using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthAndDamage : MonoBehaviour
{
    public int vida = 100;
    public Slider vidaVisual;

    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
    }
    private void Update()
    {
        vidaVisual.GetComponent<Slider>().value = vida;
        if (vida <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}
