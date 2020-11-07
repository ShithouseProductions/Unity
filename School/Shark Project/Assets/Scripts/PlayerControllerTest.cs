using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    [SerializeField] protected float walkSpeed;

    private Rigidbody rb;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        //Non-Physics stuff
        
        //Directional Input
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        moveDirection = (horizontalMovement * transform.right + verticalMovement * transform.forward).normalized;
    }

    // FixedUpdate is called every physics update (about once every 50ms)
    void FixedUpdate()
    {
        //Physics Stuff

        Move();
    }

    void Move()
    {
        rb.velocity = moveDirection * walkSpeed * Time.deltaTime;
    }
}
