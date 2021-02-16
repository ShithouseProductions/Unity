using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killcounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void killCounterfunction() 
    {
       
        killCounter++;
    }
 [SerializeField] public int killCounter;
}
