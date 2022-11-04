using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyBall;
    public Transform enemigoShoot;
    public Transform player;
    private Vector3 enemyPosition;
    [SerializeField]
    private GameObject enemigo1;
    [SerializeField]
    private float speedX = 2f;
    [SerializeField]
    private float speedZ = 2f;
    [SerializeField]
    private int enemyType;
    [SerializeField]
    private float speedXEnemy2 = 2f;
    private float randomTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        switch (enemyType)
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

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        enemyPosition = new Vector3(enemigoShoot.transform.position.x, enemigoShoot.transform.position.y, enemigoShoot.transform.position.z);

    }
    public void DispararBala()
    {
        if( enemyType == 1)
            
        {
            enemyBall.transform.LookAt(player);
            Instantiate(enemyBall, enemyPosition, enemyBall.transform.rotation); 
        }
        if (enemyType == 2)
        {
            Instantiate(enemyBall, transform.position, enemyBall.transform.rotation);
            randomTime = Random.Range(1, 3);
            Invoke("DispararBala", randomTime);
        }
    }

    public void MoveEnemy()
    {
        switch (enemyType)
        {
            case 1:
                {
                    transform.Translate(speedX * Time.deltaTime, 0, speedZ * Time.deltaTime);
                    if(transform.position.x > -7)
                    {
                        Destroy(enemigo1);
                    }
                    break;
                }
            case 2:
                {
                    if (transform.position.x > 7 || transform.position.x < -7)
                    { speedXEnemy2 *= -1; }
                    transform.Translate(speedXEnemy2 * Time.deltaTime, 0, 0);
                    break;
                }
        }
    }
}
