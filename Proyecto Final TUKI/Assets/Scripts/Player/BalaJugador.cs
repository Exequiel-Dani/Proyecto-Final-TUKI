using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour
{
    public int cantidad = 10;
    //public GameObject Enemigo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo")
        {
            other.GetComponent<VidaEnemigo>().RestarVidaEnemigo(cantidad);
            Destroy(gameObject);        

            
        }
        
    }
    private void Update()
    {
        
    }

    

}
