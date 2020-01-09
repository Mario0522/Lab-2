using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private float xBound = 80.0f;
    private float zBound = 80.0f;
    private Rigidbody shooterRb;
    
    // Start is called before the first frame update
    void Start()
    {
        shooterRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        PlayerConstraints();
    }

    // Moves player using arrow keys
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        shooterRb.AddForce(Vector3.forward * speed * verticalInput);
        shooterRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    // Sets X or right and left boundaries
    // Sets top Z boundary 
    void PlayerConstraints()
    {
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3( transform.position.x, transform.position.y, zBound);
        }
    }
}
