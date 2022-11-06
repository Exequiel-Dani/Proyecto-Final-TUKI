using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAbleObject : MonoBehaviour
{
    public bool isPickAble = true;
    //public GameObject Objeto;
    // Start is called before the first frame update
    void Start()
    {
        //Objeto = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject ;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "PlayerInteractionZone")
        {
            other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;
        }
    }
}
