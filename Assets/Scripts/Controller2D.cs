using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    //Speed of the Dog
    public float topSpeed = 10f;

    //Tells the sprite which direction it is facing
    bool facingRight = true;

    //get reference to animator
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //Fixed Update Physics
    void FixedUpdate()
    {
        //Gets move direction
        float move = Input.GetAxis("Horizontal");

        //Adds the velocity to the rigidbody in the move direction * character speed
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);

        anim.SetFloat("Speed", Mathf.Abs(move));
        

    }

    void Flip()
    {
        //Says that we are facing the opposite direction
        facingRight = !facingRight;

        //Gets the local scale
        Vector3 theScale = transform.localScale;

        //Flips on the x-axis
        theScale.x *= -1;

        //Applies it on the local scale
        transform.localScale = theScale;
    }
}
