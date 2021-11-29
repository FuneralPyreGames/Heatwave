using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public SceneChangeManager sceneChangeManager;
    public Audio Audio;
    public PersistentData persistentData;
    public SaveManager saveManager;
    void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio = persistentComponents.GetComponent<Audio>();
        sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        persistentData = persistentComponents.GetComponent<PersistentData>();
        persistentData.levelSelectUnlocked = true;
        saveManager = persistentComponents.GetComponent<SaveManager>();
        saveManager.SaveGame();
        Audio.PlayMainMenuMusic();
    }
    public void LoadMainMenu()
    {
        sceneChangeManager.LoadLevel("MainMenu");
    }
}
