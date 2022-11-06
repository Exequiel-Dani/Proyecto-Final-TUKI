using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueZ : MonoBehaviour
{
    public int cantidad = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<HealthAndDamage>().RestarVida( cantidad);
            AudioManager.instance.Play("Ataque");


            
        }

    }
}
