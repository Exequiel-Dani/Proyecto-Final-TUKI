using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Vector3 DistanciaCamara;
    public Transform target;
    [Range (0, 1)] public float LerpValue; 
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("PlayerFinal").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + DistanciaCamara, LerpValue);
        transform.LookAt(target);
    }
}
