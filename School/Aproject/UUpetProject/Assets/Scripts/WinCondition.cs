using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    //Is intended to be a function to be triggered when the player touches the collisionbox. 
    //Supposed to transition them to the "win" screen.
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("YO! you transitioned to the end scene");
            SceneManager.LoadScene(4);
        }
    }
}
