using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoMoneda : MonoBehaviour
{
    private float velocidad = -2f;
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
   
   private void OnTriggerEnter(Collider Other)
   {
    Debug.Log("detecto la colision");
    Destroy(gameObject); // esto destruira la moneda
   }
   public void MoverObjeto()
   {
    if (transform.parent.position.x > 7f || transform.parent.position.x < -2f) 
    {
     velocidad *= -1;
    }
    transform.parent.Translate(velocidad*Time.deltaTime, 0, 0);
   }

}
