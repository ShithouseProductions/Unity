using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingLever : MonoBehaviour
{
    private GameObject gO;
    [SerializeField] protected float frequency = 1f;
    private SpringJoint2D sJ;

    // Start is called before the first frame update
    void Start()
    {
        gO = GameObject.FindGameObjectWithTag("Spring");
        sJ = gO.GetComponent<SpringJoint2D>();
        sJ.frequency = frequency;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PullTensionLever()
    {
        frequency += 0.5f;
        sJ.frequency = frequency;

    }
}
