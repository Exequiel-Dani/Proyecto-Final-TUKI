using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiModAtaq : MonoBehaviour
{
  public GameObject garras;


	[SerializeField]
	private Transform objetivo;
	[SerializeField]
	private UnityEngine.AI.NavMeshAgent agente;

  [SerializeField]
  float tiempoReaccion=0.0f;

  bool espera;
  bool corre;
  
  bool gira;


    // Start is called before the first frame update
    private void Awake()
    {
		agente=GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    // Update is called once per frame
   

void Update()
    {
       
    
    }


    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            GetComponent<Animator>().SetBool("activo",true);
            
            agente.SetDestination(objetivo.position);
        } if(collision.gameObject.tag!="Player") {
          GetComponent<Animator>().SetBool("activo",false);
        }
       Invoke("activo",tiempoReaccion);
    }

    
}
