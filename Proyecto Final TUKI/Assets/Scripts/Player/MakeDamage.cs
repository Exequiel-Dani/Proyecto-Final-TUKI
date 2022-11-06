using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int cantidad = 10;

    public int cantidadDanio=10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<HealthAndDamage>().RestarVida( cantidad);
        }

        if (other.tag == "Enemigo")
        {
            transform.parent=other.transform;
            other.GetComponent<VidaEnemigoZ>().RecibirDanio(cantidadDanio);
           
            //Destroy(gameObject);                    
        }

    }
}
