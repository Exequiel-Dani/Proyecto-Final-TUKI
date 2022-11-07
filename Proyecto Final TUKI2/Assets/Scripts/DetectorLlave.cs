using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectorLlave : MonoBehaviour
{
    public bool activo;
    public GameObject Llave;
    public GameObject Premio;
    public Transform ubicacionLlave;
    public GameObject ubicacionSpawn;
    //public Transform Spawn;
    public TextMeshProUGUI Mision;
    public TextMeshProUGUI DetectaLlave;
    // Start is called before the first frame update
    void Start()
    {
        ubicacionLlave = GetComponentInParent<Transform>();
        Llave = GameObject.Find("ContenedorLlave");
        ubicacionSpawn = GameObject.Find("SpawnLlave");
        //Spawn = ubicacionSpawn.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (activo == true)
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("TUKI");
                DetectaLlave.enabled = false;
                Llave.transform.SetParent(ubicacionLlave);
                Llave.GetComponent<PickAbleObject>().isPickAble = false;
                Invoke("MuestraMision", 0);
                Invoke("OcultarMision", 10);
                activo = false;
                //Llave.GetComponent<PickAbleObject>().isPickAble = false;



            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Llave")
        {
            activo = true;
            DetectaLlave.enabled = true;


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Llave")
        {
            //DetectaPremio.enabled = false;
            activo = false;
            DetectaLlave.enabled = false;
        }
    }
    private void MuestraMision()
    {
        Mision.enabled = true;
        Instantiate(Premio, ubicacionSpawn.transform.position, ubicacionSpawn.transform.rotation);
        
    }
    private void OcultarMision()
    {
        Mision.enabled = false;
    }
}
