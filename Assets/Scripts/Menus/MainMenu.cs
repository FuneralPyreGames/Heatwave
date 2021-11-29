using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public GameObject warningMenu;
    public GameObject optionsMenu;
    public GameObject levelSelectNotUnlocked;
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public SaveManager saveManager;
    public void Awake()
    {
        StartCoroutine(WaitToGetComponents());
    }
    public void OpenOptionsMenu()
    {
        optionsMenu.SetActive(true);
    }
    public void OpenWarningMenu()
    {
        warningMenu.SetActive(true);
    }
    public void CloseWarningMenu()
    {
        warningMenu.SetActive(false);
    }
    public void StartNewGame()
    {
        persistentData.ResetGame();
        sceneChangeManager.LoadLevel(persistentData.firstLevel);
    }
    public void LoadGame()
    {
        saveManager.LoadSaves();
        persistentData.LoadNextLevel();
    }
    public void Quit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
    public void OpenLevelSelect()
    {
        if(persistentData.levelSelectUnlocked == false)
        {
            levelSelectNotUnlocked.SetActive(true);
        }
        else if (persistentData.levelSelectUnlocked == true)
        {
            print("Open Level Select");
        }
    }
    public void GoBack()
    {
        levelSelectNotUnlocked.SetActive(false);
    }
    IEnumerator WaitToGetComponents()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        saveManager = persistentComponents.GetComponent<SaveManager>();
        saveManager.LoadSaves();
    }
}
