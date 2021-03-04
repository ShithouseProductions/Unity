using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCollisionMouth : MonoBehaviour
{
    internal bool hitMouth;
    internal int timer;
    [SerializeField] protected int timerLimit;
    [SerializeField] Animator animator;
    [SerializeField] AudioFileManager AuM;

    private void FixedUpdate()
    {
        if (hitMouth == true)
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
        hitMouth = true;
        animator.SetBool("Hit", true);
        AuM.Sound3();
    }
}
