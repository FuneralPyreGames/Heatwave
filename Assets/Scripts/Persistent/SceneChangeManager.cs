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
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        switch (levelToLoad)
        {
            case "MainMenu":
                SceneManager.LoadScene("MainMenu");
                break;
            case "Level 1":
                SceneManager.LoadScene("Level 1");
                break;
            case "Level 2":
                SceneManager.LoadScene("Level 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Level 3");
                break;
            default:
                break;
        }
    }
}
