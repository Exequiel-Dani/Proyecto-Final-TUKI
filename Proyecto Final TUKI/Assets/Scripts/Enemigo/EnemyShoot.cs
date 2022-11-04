using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;
    public DetectarEnemigo detectarEnemigo;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<DetectarEnemigo>().activado)                           //GameObject.FindWithTag("Enemigo") == true )
        {
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation);
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * BalaVelocidad);
            Destroy(BalaTemporal, 5f);
        }
        
    }
}
