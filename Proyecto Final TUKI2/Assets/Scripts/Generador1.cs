using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador1 : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy1;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }


    public void GenerateEnemy()
    {
        Instantiate(enemy1, transform.position, transform.rotation);
    }
}
