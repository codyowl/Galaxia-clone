using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space_shooter_movement : MonoBehaviour
{
    // for movement speed on the component box gui control
    public float movementSpeed = 10.0f;

    public Rigidbody2D Shooter;

    // Start is called before the first frame update
    void Start()
    {
        Shooter = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMovement();   
    }

    public void PlayerMovement()
    {
        
        Shooter.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * movementSpeed;

    }
}

