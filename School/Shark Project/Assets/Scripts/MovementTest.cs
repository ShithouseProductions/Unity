using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    //Creates a character controller object
    CharacterController characterController;
    //Creates a movementspeed variable
    [SerializeField] protected float movementSpeed = 1.0f;
    //creates a gravity variable
    [SerializeField] protected float gravity = 1.0f;
    //creates a velocity variable
    private float velocity = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * movementSpeed;
        float vertical = Input.GetAxis("Vertical") * movementSpeed;
        characterController.Move((Vector3.right * horizontal + Vector3.forward * vertical) * Time.deltaTime);

        //Gravity
        if (characterController.isGrounded)
        {
            velocity = 0f;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }
    }
}
