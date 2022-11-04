using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 5;
    public DetectarEnemigo detectarEnemigo;
    public Transform Enemigo;
    public bool activado;
   
    // Start is called before the first frame update
    void Start()
    {
        detectarEnemigo.GetComponent<DetectarEnemigo>();
        
    }

    // Update is called once per frame
    void Update()
    {

        moveEnemy();
        


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            activado = true;
            detectarEnemigo.enabled = true;
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            activado = false;
            

        }
    }
    void moveEnemy()
    {
        Enemigo.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        if (Enemigo.transform.position.z >= 10)
        {
            speed *= -1;
            Enemigo.transform.Rotate(0, 180, 0);
        }
        if (Enemigo.transform.position.z <= -2)
        {
            speed *= -1;
            Enemigo.transform.Rotate(0, 180, 0);
        }
    }

}
