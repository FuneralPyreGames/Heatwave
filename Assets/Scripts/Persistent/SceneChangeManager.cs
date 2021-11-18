using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void LoadLevel(string levelToLoad)
    {
        switch (levelToLoad)
        {
            case "MainMenu":
                SceneManager.LoadScene("MainMenu");
                break;
            case "Level 1":
                SceneManager.LoadScene("Level 1");
                break;
            default:
                break;
        }
    }
}
