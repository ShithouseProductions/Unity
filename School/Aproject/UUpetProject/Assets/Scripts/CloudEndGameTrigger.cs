using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudEndGameTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("B");

        if (collision.collider.tag == "Player")
        {
            Debug.Log("V");
        }

    }
}
