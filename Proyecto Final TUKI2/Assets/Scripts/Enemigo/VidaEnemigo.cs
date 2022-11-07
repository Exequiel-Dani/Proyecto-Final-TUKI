using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemigo : MonoBehaviour
{
    public int vidaEnemigo = 100;
    public Slider vidaVisualEnemy;

    public void RestarVidaEnemigo (int cantidad)
    {
        vidaEnemigo -= cantidad;
    }

    // Update is called once per frame
    void Update()
    {
        vidaVisualEnemy.value = vidaEnemigo;
        if (vidaEnemigo <= 0)
        {
            Debug.Log("EnemigoDestruido");
            Destroy(gameObject);
        }
    }
}
