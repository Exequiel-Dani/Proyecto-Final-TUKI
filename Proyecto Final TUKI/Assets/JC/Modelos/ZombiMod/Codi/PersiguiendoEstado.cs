using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PersiguiendoEstado : StateMachineBehaviour
{
    NavMeshAgent agente;
    Transform jugador;

    [SerializeField]
    float rangoPerseguir=10f;

    [SerializeField]
    float rangoAtaque=4f;

    [SerializeField]
    float velocidadAgente=3.8f;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agente=animator.GetComponent<NavMeshAgent>();
        jugador=GameObject.FindGameObjectWithTag("Player").transform;
        agente.speed=velocidadAgente;
   
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agente.SetDestination(jugador.position);
        float distance=Vector3.Distance(jugador.position, animator.transform.position);
        if(distance<rangoPerseguir){
            animator.SetBool("estaPersiguiendo", false);
        }
        if(distance<rangoAtaque)
        {
            animator.SetBool("estaAtacando", true);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agente.SetDestination(animator.transform.position);
    }

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
