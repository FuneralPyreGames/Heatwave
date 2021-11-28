using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExit : MonoBehaviour
{
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public SaveManager saveManager;
    public Gun gun;
    public int currentLevel;
    public GameObject levelEndScreen;
    public GameObject notLevelSelectText;
    public GameObject levelSelectText;
    public GameObject nextLevel;
    private void Awake()
    {
        while (GameObject.Find("PersistentComponents(Clone)") == null)
        {
            print("Unable to find components");
        }
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        saveManager = persistentComponents.GetComponent<SaveManager>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        print("Trigger Entered");
        if (collision.gameObject.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            persistentData.SetLastCompletedLevel(currentLevel);
            Time.timeScale = 0f;
            persistentData.SetCompletionState(gun, currentLevel);
            levelEndScreen.SetActive(true);
            if (persistentData.fromLevelSelect == false)
            {
                notLevelSelectText.SetActive(true);
                nextLevel.SetActive(true);
            }
            if (persistentData.fromLevelSelect == true)
            {
                levelSelectText.SetActive(true);
            }
        }
    }
    public void LoadTheNextLevel()
    {
        saveManager.SaveGame();
        Time.timeScale = 1f;
        persistentData.LoadNextLevel();
    }
    public void LoadMainMenu()
    {
        saveManager.SaveGame();
        Time.timeScale = 1f;
        sceneChangeManager.LoadLevel("MainMenu");
    }
}
