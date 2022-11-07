using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDamage : MonoBehaviour
{
    public int cantidad = 20;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<HealthAndDamage>().RestarVida( cantidad);
            Destroy(gameObject);
        }
        if (other.tag == "Obstaculo")
        {
            Destroy(gameObject);
        }
    }
}
