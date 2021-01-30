using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //VARIABLES
    public float speed;//player speed
    private Rigidbody2D myRigidbody;//reference to rigidbody  
    private Vector3 change; //vector 
    private Animator animator; //reference to animator 

    // Start is called before the first frame update
    void Start() {
    myRigidbody = GetComponent<Rigidbody2D>();//calls ridgedbody 
        animator = GetComponent<Animator>(); //sets the animator varable to the component of animator 
    }

    // Update is called once per frame
    void Update() {
    change = Vector3.zero;  //resets how much player movement has changed every frame
        change.x = Input.GetAxisRaw("Horizontal"); //gets horizontal axis from change in x axis
        change.y = Input.GetAxisRaw("Vertical"); //gets vertical axis from change in y axis
        updateAnimationMove(); //uses updateAnimationMove function 

        }

    void updateAnimationMove(){//function for animation/movement scripting 
        if (change != Vector3.zero)
        { //if theres a change then 
            MoveCharacter(); //call the move character function 
            animator.SetFloat("moveX", change.x); //sets the float move.X to value of change.x
            animator.SetFloat("moveY", change.y); //sets the float move.Y to value of change.y
            animator.SetBool("moving", true); // sets the bool moving to be true 
        }
        else
        {//if theres no change 
            animator.SetBool("moving", false); // sets the bool moving to be false 
        }
    }



    void MoveCharacter() { //function for character movement 
        myRigidbody.MovePosition(
            transform.position + change.normalized * speed * Time.deltaTime); //takes players position adds change to it that is multiplied by the speed variable thats being manipulated by time passed by previous frame 

    }
}
