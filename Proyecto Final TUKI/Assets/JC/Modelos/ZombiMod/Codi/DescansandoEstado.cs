using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescansandoEstado : StateMachineBehaviour
{
    [SerializeField]
    private float temporizador;

    [SerializeField]
    Transform jugador;
    [SerializeField]
    private float rangoPerseguir=10f;


    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        temporizador= 0;
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        temporizador+= Time.deltaTime;
        if(temporizador>5)
        {
            animator.SetBool("isPatrullando", true);
        }

         float distance=Vector3.Distance(jugador.position, animator.transform.position);
        if(distance<rangoPerseguir){
            animator.SetBool("estaPersiguiendo", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }
    
}
