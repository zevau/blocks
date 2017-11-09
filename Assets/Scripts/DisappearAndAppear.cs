using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearAndAppear : MonoBehaviour {

    int warningTimes = 5;
    float waitingTime = 0.50f;
    Color originalColor;
    Material material;
    bool collided = false;

    // Use this for initialization
    void Start () {
        material = GetComponent<Renderer>().material;
        originalColor = material.color;
    }
	
	// Update is called once per frame
	void Update () {
	}

    //Collision
    private void OnCollisionEnter(Collision collision)
    {
        //detects collision with player
        if (collision.gameObject.name == "Player" && !collided) { 
            collided = true;
            Debug.Log("collision with player");
            StartCoroutine(changeColour());
        }
    }

    //Change the Color of the Object
    //yield (waiting) only works in IEnumerator
    IEnumerator changeColour()
    {
        float sub = 0.1f;
        for (int i = 0; i <= warningTimes; i++) {
            Debug.Log("Durchgang " + i);
            material.color = Color.red;
            yield return new WaitForSeconds(waitingTime);
            Debug.Log("1 es wurde gewartet für" + waitingTime + "Sekunden.");
            material.color = originalColor;
            Debug.Log("altes Material");
            yield return new WaitForSeconds(waitingTime);
            Debug.Log("2 es wurde gewartet für" + waitingTime + "Sekunden.");
            waitingTime = waitingTime - sub;
            sub = sub * 0.8f;
            Debug.Log("neue Zeit: " + waitingTime);
        }
        sub = 0.1f;
        gameObject.SetActive(false);
        Invoke("reset", 5);
    }

    void reset() {
        Debug.Log("reset");
        collided = false;
        waitingTime = 0.60f;
        gameObject.SetActive(true);
        Debug.Log(gameObject.activeSelf.ToString());
    }
}
