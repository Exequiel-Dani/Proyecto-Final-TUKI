using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaRoja : MonoBehaviour
{
    private float velocidad = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GirarObjeto();
        MoverObjeto();

    }
    public void GirarObjeto()
    {transform.Rotate(115*Time.deltaTime,0,0); // hacemos que gire la moneda
    
    }
   
   public void MoverObjeto()
   {
    if (transform.parent.position.z > 7f || transform.parent.position.z < -7f) 
    {
     velocidad *= -1;
    }
    transform.parent.Translate(0, 0, velocidad*Time.deltaTime);
   }

}