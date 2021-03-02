using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleasingStudents : MonoBehaviour
{
    [SerializeField] protected HingeJoint2D salvo;
    [SerializeField] protected GameObject looseScripts;
    [SerializeField]
    protected void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Salvo Loosend");
        salvo.enabled = false;
    }

}
