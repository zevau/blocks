using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    //set jumpforce
    public int force = 100;

    Rigidbody playerRigidBody;
    bool collided = false;

    //Collision
    private void OnCollisionEnter(Collision collision)
    {   
        
        //if collision with player
        if(collision.gameObject.name == "Player" && !collided)
        {
            playerRigidBody = collision.gameObject.GetComponent<Rigidbody>(); //get rigidbody of player
            playerRigidBody.AddForce(new Vector3(0, force, 0)); //let player jump
        }
    }
}
