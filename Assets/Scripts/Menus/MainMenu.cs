using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    public GameObject warningMenu;
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public void Awake()
    {
        while(GameObject.Find("PersistentComponents(Clone)") == null)
        {
            print("Unable to find components");
        }
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
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
    public void Quit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
