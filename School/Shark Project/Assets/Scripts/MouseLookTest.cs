using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookTest : MonoBehaviour
{
    //horizontal rotation speed
    [SerializeField] protected float horizontalRotationSpeed = 100f;

    //vertical rotation speed
    [SerializeField] protected float verticalRotationSpeed = 100f;

    //rotation values
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    //this creates a cam object which you can link to the actualy camera in the scene 
    private Camera cam;
    
    // Start is called before the first frame update
    void Start()
    {
        //here we call the "Main Camera" in the scene and tells it to link to the camera object cam in the script
        //this means that all rotations we do the cam object wil be applied to the "Main Camera"
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //Calling the input from the mouse and multiplying it with the rotationspeed I want as well as locking it to the
        //frame rate as to not get look sensitivity on high refresh rate screens. This I have now learned the hard way xD
        float mouseX = Input.GetAxis("Mouse X") * horizontalRotationSpeed * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * verticalRotationSpeed * Time.deltaTime;

        //setting the rotation values to the multiplied values from above
        yRotation += mouseX;
        xRotation -= mouseY;
        //calmping the rotations so that they can't exceed a certain treshhold in certain directions, in this case the y and z values
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        //transforming the camera object cam after euler angles with the rotations from above
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
    }
}
