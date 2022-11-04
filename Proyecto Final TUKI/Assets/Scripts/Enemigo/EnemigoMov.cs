using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMov : MonoBehaviour
{
    [SerializeField]
    private GameObject Balaenemiga;
    [SerializeField]
    private GameObject Enemigo1;
    [SerializeField]
    private float speed1 = 2f;
    [SerializeField]
    private float speed2 = 2f;
    [SerializeField]
    private int tipoenemigo;
    private float randomTime = 0;

    private void Start()
    {

        switch (tipoenemigo)
        {
            case 1:
                {
                    InvokeRepeating("DispararBala", 0, 2f);
                    break;
                }
            case 2:
                {
                    Invoke("DispararBala", randomTime);
                    break;
                    
                }



        }

    }

      void Update()
    {
        MovimientoEnemigo();

    }

    public void DispararBala()
    {
        Instantiate(Balaenemiga, transform.position, transform.rotation);
        if (tipoenemigo == 2)
        {
            randomTime = Random.Range(1, 3);
            Invoke("DispararBala", randomTime);
        }
    }

    public void MovimientoEnemigo()
    {
        switch (tipoenemigo)
        {
            case 1:
                {
                    transform.Translate(speed1 * Time.deltaTime, 0, speed1 * Time.deltaTime);
                    if (transform.position.x < -7)
                    {
                        Destroy(Enemigo1);
                    }
                    break;
                }
            case 2:
                {
                    if (transform.position.x > 7 || transform.position.x < -7)
                    { speed2 *= -1; }
                    transform.Translate(speed2 * Time.deltaTime, 0, 0);
                    break;
                }
        }
    }
}
