using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    
    private Rigidbody rb;
    
    public float velocityFactor = 0.1f;
    public GameObject player;

	// Use this for initialization
	void Start () {
        rb = player.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float angle = gameObject.transform.eulerAngles.z;
        float y = rb.velocity.y;
        Debug.Log("z: " + angle);
        if (angle > 180)
        {
            rb.velocity = new Vector3((360 - angle) * velocityFactor, y, 0);
        }
        else
        {
            rb.velocity = new Vector3(-angle * velocityFactor, y, 0);
        }
    }
}
