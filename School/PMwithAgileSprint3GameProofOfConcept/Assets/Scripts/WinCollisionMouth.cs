using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollisionMouth : MonoBehaviour
{
    internal bool hit;
    internal int timer;
    [SerializeField] protected int timerLimit;

    private void FixedUpdate()
    {
        if (hit == true)
        {
            timer++;
        }

        if (timer >= timerLimit)
        {
            SceneManager.LoadScene("Win Game Scene");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hit = true;
    }
}
