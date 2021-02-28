using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfMassReadjustment : MonoBehaviour
{
    [SerializeField] protected Rigidbody2D rb;
    private Vector2 com;
    // Start is called before the first frame update
    void Start()
    {
        com = new Vector2(0f, 0f);
        rb.centerOfMass = com;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
