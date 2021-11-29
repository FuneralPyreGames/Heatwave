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
    public GameObject creditsMenu;
    public GameObject howToPlay;
    public GameObject howToPlay1;
    public GameObject howToPlay2;
    public GameObject howToPlay3;
    public GameObject howToPlay4;
    public GameObject howToPlay5;
    public GameObject howToPlay6;
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public SaveManager saveManager;
    public Audio Audio;
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
        Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayMainMenuMusic();
        saveManager.LoadSaves();
    }
    public void OpenCredits()
    {
        creditsMenu.SetActive(true);
    }
    public void CloseCredits()
    {
        creditsMenu.SetActive(false);
    }
    public void LoadHowToPlay1()
    {
        howToPlay.SetActive(true);
        howToPlay1.SetActive(true);
    }
    public void LoadHowToPlay2()
    {
        howToPlay1.SetActive(false);
        howToPlay2.SetActive(true);
    }
    public void LoadHowToPlay3()
    {
        howToPlay2.SetActive(false);
        howToPlay3.SetActive(true);
    }
    public void LoadHowToPlay4()
    {
        howToPlay3.SetActive(false);
        howToPlay4.SetActive(true);
    }
    public void LoadHowToPlay5()
    {
        howToPlay4.SetActive(false);
        howToPlay5.SetActive(true);
    }
    public void LoadHowToPlay6()
    {
        howToPlay5.SetActive(false);
        howToPlay6.SetActive(true);
    }
    public void CloseHowToPlay()
    {
        howToPlay1.SetActive(false);
        howToPlay2.SetActive(false);
        howToPlay3.SetActive(false);
        howToPlay4.SetActive(false);
        howToPlay5.SetActive(false);
        howToPlay6.SetActive(false);
        howToPlay.SetActive(false);
    }
}
