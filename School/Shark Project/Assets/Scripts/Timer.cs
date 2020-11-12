using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private int timer;
    [SerializeField] private int x = 1100;
    [SerializeField] public int winCondition;
    
    public void WinFunction()
    {
        winCondition++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer >= x && winCondition <= 4)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (timer <= x && winCondition >= 5)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    void FixedUpdate()
    {
        timer++; 
    }
}
