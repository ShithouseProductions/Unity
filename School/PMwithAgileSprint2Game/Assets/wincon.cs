using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wincon : MonoBehaviour
{
    [SerializeField] protected int timer;
    [SerializeField] public int killCounter;
    [SerializeField] public int barrierHP;
    [SerializeField] private int timerWin;
    [SerializeField] private int killWin;
    [SerializeField] private int barrierWin;

    void Update()
    {
        WinCondition();
        LoseCondition();
    }

    void FixedUpdate()
    {
        timer++;
    }

    private void WinCondition()
    {
        if (timer <= timerWin && barrierHP >= barrierWin && killCounter >= killWin)
        {
            //SceneManager.LoadScene(2);
            Debug.Log("good boi");
        }

    }


    private void LoseCondition()
    {
        if (timer >= timerWin && killCounter < killWin)
        {
            Debug.Log("You Lose. You did not have enough kills before the timer ran out");
        }

        if (barrierHP < barrierWin)
        {
            Debug.Log("You Lose. Barrier Failed");
        }

    }
    public void Barrier()
    {
        barrierHP--;
    }

    public void KillCounter()
    {
        killCounter++;
    }

}