using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation);
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * BalaVelocidad);
            Destroy(BalaTemporal, 5f);
        }
    }
}
