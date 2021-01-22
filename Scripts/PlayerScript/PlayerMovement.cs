using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myBody;
    public float moveSpeed = 1f;
    
   


    void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    

    void FixedUpdate()
    {
        Move();
    }
    void Move() {
        if(Input.GetAxisRaw("Vertical") > 0f) {
            myBody.velocity = new Vector2(myBody.velocity.x, moveSpeed);
        }
        if(Input.GetAxisRaw("Vertical") < 0f) {
            myBody.velocity = new Vector2(myBody.velocity.x, -moveSpeed);
            
            
        }



    } //Move ends






} //class
