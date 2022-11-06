using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZModMov : MonoBehaviour
{
[SerializeField]
float velMov, velRot;

[SerializeField]
float tiempoReaccion=0.8f;

int movimiento;
bool espera, corre, gira;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(espera){
            GetComponent<Animator>().SetBool("activo",false);

        }
        if(corre){
            GetComponent<Animator>().SetBool("activo",true);
            transform.position+=(transform.forward* velMov* Time.deltaTime);

        }
        if(gira){
            transform.Rotate(Vector3.up * velRot * Time.deltaTime);
        }
    }
    void accion()
    {
        movimiento= Random.Range(1,4);

        if(movimiento==1)
        {
            corre=true;
            espera=false;
        }
        if(movimiento==2)
        {
            espera=true;
            corre=false;
        }
        if(movimiento==3)
        {
            gira=true;
            StartCoroutine(tiempoGiro());
        }

        Invoke("accion", tiempoReaccion);
    }

    IEnumerator tiempoGiro()
    {
        yield return new WaitForSeconds(2);
        gira=false;
    }
}
