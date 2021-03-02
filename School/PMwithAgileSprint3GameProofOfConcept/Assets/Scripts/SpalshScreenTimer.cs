using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpalshScreenTimer : MonoBehaviour
{
    internal int timer;
    [SerializeField] protected int timerLimit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        timer++;

        if (timer >= timerLimit)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
