using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSTest : MonoBehaviour
{
    [SerializeField] protected CharacterController chracterController;
    [SerializeField] protected float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = transform.forward;

        chracterController.Move(move * speed * Time.deltaTime);
    }
}
