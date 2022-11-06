using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour

{
    public GameObject ObjectToPickUp;
    public GameObject PickedObject;
    public Transform interactionZone;
    //public bool isPickable = false;


    //public void OnTriggerEnter(Collider other){if (other.tag == "PlayerInteractionZone"){
    //other.GetComponentInParent<PickUpObject>().ObjectToPickUp = this.gameObject;
    //PickedObject = 
    //isPickable = true;}}public void OnTriggerExit(Collider other){if (other.tag == "PlayerInteractionZone"){other.GetComponentInParent<PickUpObject>().ObjectToPickUp = null;isPickable = false;}}

    //public void AgarrarObjeto(GameObject objeto)
    
        //ObjectToPickUp = objeto;
    
    private void Start()
    {
         
    }
    void Update()
    {
        if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<PickAbleObject>().isPickAble && PickedObject == null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                PickedObject = ObjectToPickUp;
                PickedObject.GetComponent<PickAbleObject>().isPickAble = false;
                PickedObject.transform.SetParent(interactionZone);
                PickedObject.transform.position = interactionZone.position;
                PickedObject.GetComponent<Rigidbody>().useGravity = false;
                PickedObject.GetComponent<Rigidbody>().isKinematic = true;
                PickedObject.GetComponentInChildren<MeshRenderer>().enabled = false;
                //isPickable = false;
               
                
            }
            
            
        }
         else if (PickedObject != null)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("Soltar");
                PickedObject.GetComponent<PickAbleObject>().isPickAble = true;
                PickedObject.transform.SetParent(null);
                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject.GetComponentInChildren<MeshRenderer>().enabled = true;
                PickedObject = null;

            }

        }

    }
}
// codigo alternativo  if (ObjectToPickUp == true || ObjectToPickUp.GetComponent<PickableObject>().isPickable || PickedObject == null){if (Input.GetKeyDown(KeyCode.F)){
        //PickedObject = ObjectToPickUp;
        //PickedObject.GetComponent<PickableObject>().isPickable = false;
        //PickedObject.transform.SetParent(interactionZone);
        //PickedObject.transform.position = interactionZone.position;
        //PickedObject.GetComponent<Rigidbody>().useGravity = false;
        //PickedObject.GetComponent<Rigidbody>().isKinematic = true;}}
//if (Input.GetKeyDown(KeyCode.G)){PickedObject.transform.SetParent(null);PickedObject.GetComponent<PickableObject>().isPickable = true;

    //PickedObject.GetComponent<Rigidbody>().useGravity = true;
    //PickedObject.GetComponent<Rigidbody>().isKinematic = false;
    //PickedObject = null;}
