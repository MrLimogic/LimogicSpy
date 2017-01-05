using UnityEngine;
using System.Collections;

public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class PlayerMovement : MonoBehaviour
{

    float speed = 2f; //speed at witch the car moves at
    float torqueForce = -10f; //Torgue Amount
    public Boundary boundary; //Allows this class to access variables from the Boundary class.

    Camera myGameCamera;

    // Use this for initialization
    void Start ()
    {
        myGameCamera = FindObjectOfType<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}
    // FixedUpdate is called every once per tick of the physics engine.
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); // Makes it so I don't need to type the get component each time I use the rigid body.

        if (Input.GetButton("Accelerate")) //if the key acceleration button is pressed
        {
            rb.AddForce( transform.up * speed); //Move the car along the Y axes
        }

        rb.AddTorque(0, 0, Input.GetAxis("Horizontal") * torqueForce);


    }
}
