using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroController : MonoBehaviour {


    public CharacterController2D moveController;
    public float velocidade;
    public Animator animator;

    private void FixedUpdate()
    {
        if (Input.GetKey("up"))
        {
            moveController.Move(0, false, true);
            animator.SetBool("estaPulando", true);
        }
        else
        {
            animator.SetBool("estaPulando", false);
        }
        

        if (Input.GetKey("right"))
        {
            moveController.Move(1 * velocidade, false, false);
            animator.SetBool("estaCorrendo", true);
        }
        else
        {
            if (Input.GetKey("left"))
            {
                moveController.Move(-1 * velocidade, false, false);
                animator.SetBool("estaCorrendo", true);
            }
            else
            {
                animator.SetBool("estaCorrendo", false);
            }
        }

        
        
    }
 
}
