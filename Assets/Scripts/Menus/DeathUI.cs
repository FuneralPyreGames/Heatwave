using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUI : MonoBehaviour
{
    public Audio Audio;
    public SceneChangeManager sceneChangeManager;
    public SaveManager saveManager;
    private void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        saveManager = persistentComponents.GetComponent<SaveManager>();
        Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayGameOverMusic();
    }
    public void LoadMainMenu()
    {
        saveManager.SaveGame();
        Time.timeScale = 1f;
        sceneChangeManager.LoadLevel("MainMenu");
    }
    public void RestartGame()
    {
        saveManager.SaveGame();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
