using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public Animator animator;


    void Update()
    {
        move();
    }

    private void move()
    {
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

        animator.SetFloat("Horizontal", movement.x); // horizontal yapsak yeter 
        animator.SetFloat("Vertical", movement.z);
        animator.SetFloat("movementControl", movement.magnitude);



        transform.position = transform.position + movement*Time.deltaTime;
    }
}
