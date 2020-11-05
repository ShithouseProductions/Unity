using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public float movementAcceleration = 1.0f;
    public float movementSpeed = 1.0f;
    public float horizontalFloatInput = Input.GetAxis("Horizontal");
    public float verticalFloatInput = Input.GetAxis("Vertical");
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(horizontalFloatInput, 0, verticalFloatInput) * movementSpeed * Time.deltaTime);  
    }
}
