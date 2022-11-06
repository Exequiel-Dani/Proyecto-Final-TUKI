using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrullandoEstado : StateMachineBehaviour
{

    /* variables */
   [SerializeField]
    private float temporizador;
    [SerializeField]
    private float rangoPerseguir=10;

    [SerializeField]
    Transform jugador;

    [SerializeField]
    List<Transform> puntosDePatrullaje=new List<Transform>(); //lista de puntos
    UnityEngine.AI.NavMeshAgent agente;

/* ingreso al estado */
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agente=animator.GetComponent<UnityEngine.AI.NavMeshAgent>(); //toma el componente del Agente de Navegación de malla
        temporizador= 0; // temporizador
        jugador = GameObject.FindGameObjectWithTag("Player").transform; //  el jugador es el que tiene la etiquta "Player"
        GameObject go = GameObject.FindGameObjectWithTag("PuntosDePatrullaje"); // Busca a los objetos con etiquta "Puntos de patrullaje"
        foreach(Transform t in go.transform)//para cada punto "t" se dirige a la posicion de los mismos.
        { 
            puntosDePatrullaje.Add(t); //addiciona un punto de patrullaje a la lista por cada punto encontrado.
        }
        agente.SetDestination(puntosDePatrullaje[Random.Range(0,puntosDePatrullaje.Count)].position); // dirige al agente al los puntos de patrullaje de forma aleatoria.
            
    }

/*Actualización de Estados*/
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(agente.remainingDistance<=agente.stoppingDistance) // si el agente está a menor distancia de la distancia de detención
        {
            agente.SetDestination(puntosDePatrullaje[Random.Range(0,puntosDePatrullaje.Count)].position);//el agente elige aleatoriamnete el punto siguiente.
        }
        temporizador+= Time.deltaTime; //adiciona tiempo al temporizador.
        if(temporizador>10) //si el temporizador es mayor que 10
        {
            animator.SetBool("isPatrullando", false); //deja de patrullar
        }
        float distance=Vector3.Distance(jugador.position, animator.transform.position); //establece distancia entre el agente y el jugador
        if(distance<rangoPerseguir){ //si la distancia es menor al rango para perseguir
            animator.SetBool("estaPersiguiendo", true); //cambia al estado de persecución
        }
    }

/* Salida de Estado*/
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agente.SetDestination(agente.transform.position); //el agente llega a la posición 
    }
    
     // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
