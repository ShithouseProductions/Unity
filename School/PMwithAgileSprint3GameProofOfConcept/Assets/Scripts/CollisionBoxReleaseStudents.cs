using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBoxReleaseStudents : MonoBehaviour
{
    [SerializeField] protected HingeJoint2D salvo;
    [SerializeField] protected GameObject looseScripts;

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Salvo Loosend");
        salvo.enabled = false;
    }

}
