using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformationScript : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected Rigidbody2D rb;
    
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
        Vector2 move = transform.up * speed;
        rb.velocity = -move;

    }
}
