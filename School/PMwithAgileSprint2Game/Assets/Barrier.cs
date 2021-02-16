using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] protected BoxCollider barrier;
    

    // Update is called once per frame
    void Update()
    {
        //barrier.OnCollision
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("Oscar is a cute boi");
           
        }
    }
}

