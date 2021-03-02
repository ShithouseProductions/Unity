using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReleaseCall : MonoBehaviour
{
    [SerializeField] protected HingeJoint2D groundHolder;
    [SerializeField] protected Rigidbody2D counterWeight;
    [SerializeField] protected int addedWeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReleaseArm()
    {
        groundHolder.enabled = false;
    }

    public void AddTension()
    {
        counterWeight.mass += addedWeight;
    }

    public void ResetArm()
    {
        SceneManager.LoadScene("Game Scene");
    }

    public void WinCondition()
    {
        SceneManager.LoadScene("Win Game Scene");
    }
}
