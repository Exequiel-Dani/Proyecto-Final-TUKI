using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorPremio : MonoBehaviour
{
    public TextMeshProUGUI ganaste;
    public TextMeshProUGUI DetectaPremio;
    public GameObject Premio;
    public Transform ubicacionPremio;
    public PickUpObject pickUpObject;
    public bool Activo;
    // Start is called before the first frame update
    void Start()
    {
        ubicacionPremio = GetComponentInParent<Transform>();
        pickUpObject = GetComponent<PickUpObject>();
        Premio = GameObject.Find("ContenedorPremio");//GetComponent<PickUpObject>().ObjectToPickUp;   

    }

    // Update is called once per frame
    void Update()
    {
        if (Activo == true)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("Ganaste");
                DetectaPremio.enabled = false;
                Premio.transform.SetParent(ubicacionPremio);
                Premio.GetComponent<PickAbleObject>().isPickAble = false;
                ganaste.enabled = true;
                Activo = false;

                //pickUpObject.enabled = false;
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Premio" )
        {
            Activo = true;
            
            DetectaPremio.enabled = true;
                
            //activado = true;
            //InvokeRepeating("Disparar", 0, 1f);
            //enemyPatrol.enabled = false;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Premio")
        {
            DetectaPremio.enabled = false;
            Activo = false;
        }
    }
}
