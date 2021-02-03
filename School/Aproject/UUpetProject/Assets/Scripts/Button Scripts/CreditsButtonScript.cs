using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButtonScript : MonoBehaviour
{
    public void CreditsSceneSwitcher()
    {
        SceneManager.LoadScene(2);
    }
}
