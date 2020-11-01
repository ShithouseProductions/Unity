using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public CharacterController controller;

    public float playerSpeed = 0.2f;
    public float gravityAcceleration = -9.81f;

    public Transform objectNormalForceCheck;
    public float objectDistance = 0.4f;
    public LayerMask objectMask;

    Vector3 gravityVelocity;
    bool normalForceActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        normalForceActive = Physics.CheckSphere(objectNormalForceCheck.position, objectDistance, objectMask);

        if(normalForceActive && gravityVelocity.y < 0)
        {
            gravityVelocity.y = -2f;
        }

        
        gravityVelocity.y += gravityAcceleration * Time.deltaTime;
        controller.Move(gravityVelocity * Time.deltaTime);


    }
}
