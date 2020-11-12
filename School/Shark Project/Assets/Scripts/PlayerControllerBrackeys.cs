using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBrackeys : MonoBehaviour
{
    public CharacterController controller;
    [SerializeField] protected float speed; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
