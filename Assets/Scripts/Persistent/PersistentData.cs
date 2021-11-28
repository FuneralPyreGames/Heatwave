using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [Header("Options")]
    public bool fromLevelSelect;
    public string firstLevel;
    [Header("Progression")]
    public int lastCompletedLevel;
    [Header("Level 1")]
    public bool level1CompleteWithPistol;
    public bool level1CompleteWithShotgun;
    public bool level1CompleteWithRifle;
    [Header("Level 2")]
    public bool level2CompleteWithPistol;
    public bool level2CompleteWithShotgun;
    public bool level2CompleteWithRifle;
    [Header("Level 3")]
    public bool level3CompleteWithPistol;
    public bool level3CompleteWithShotgun;
    public bool level3CompleteWithRifle;
    [Header("Level 4")]
    public bool level4CompleteWithPistol;
    public bool level4CompleteWithShotgun;
    public bool level4CompleteWithRifle;
    [Header("Level 5")]
    public bool level5CompleteWithPistol;
    public bool level5CompleteWithShotgun;
    public bool level5CompleteWithRifle;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void ResetGame()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        SaveManager saveManager = persistentComponents.GetComponent<SaveManager>();
        level1CompleteWithPistol = false;
        level1CompleteWithRifle = false;
        level1CompleteWithShotgun = false;
        level2CompleteWithPistol = false;
        level2CompleteWithRifle = false;
        level2CompleteWithShotgun = false;
        level3CompleteWithPistol = false;
        level3CompleteWithShotgun = false;
        level3CompleteWithRifle = false;
        level4CompleteWithPistol = false;
        level4CompleteWithShotgun = false;
        level4CompleteWithRifle = false;
        level5CompleteWithPistol = false;
        level5CompleteWithShotgun = false;
        level5CompleteWithRifle = false;
        saveManager.ResetSaves();
    }
    public void SetLastCompletedLevel(int level)
    {
        lastCompletedLevel = level;
    }
    public void LoadNextLevel()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        SceneChangeManager sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        int nextLevel = lastCompletedLevel += 1;
        switch (nextLevel)
        {
            case 1:
                sceneChangeManager.LoadLevel("Level 1");
                break;
            case 2:
                sceneChangeManager.LoadLevel("Level 2");
                break;
            case 3:
                sceneChangeManager.LoadLevel("Level 3");
                break;
            case 4:
                sceneChangeManager.LoadLevel("Level 4");
                break;
            case 5:
                sceneChangeManager.LoadLevel("Level 5");
                break;
            case 6:
                sceneChangeManager.LoadLevel("MainMenu");
                break;
            default:
                break;
        }
    }
    public void SetCompletionState(Gun gun, int currentLevel)
    {
        switch (currentLevel)
        {
            case 1:
                if (gun.gunSelection == 0)
                {
                    level1CompleteWithPistol = true;
                }
                else if (gun.gunSelection == 1)
                {
                    level1CompleteWithShotgun = true;
                }
                else if (gun.gunSelection == 2)
                {
                    level1CompleteWithRifle = true;
                }
                break;
            case 2:
                if (gun.gunSelection == 0)
                {
                    level2CompleteWithPistol = true;
                }
                else if (gun.gunSelection == 1)
                {
                    level2CompleteWithShotgun = true;
                }
                else if (gun.gunSelection == 2)
                {
                    level2CompleteWithRifle = true;
                }
                break;
            case 3:
                if (gun.gunSelection == 0)
                {
                    level3CompleteWithPistol = true;
                }
                else if (gun.gunSelection == 1)
                {
                    level3CompleteWithShotgun = true;
                }
                else if (gun.gunSelection == 2)
                {
                    level3CompleteWithRifle = true;
                }
                break;
            case 4:
                if (gun.gunSelection == 0)
                {
                    level4CompleteWithPistol = true;
                }
                else if (gun.gunSelection == 1)
                {
                    level4CompleteWithShotgun = true;
                }
                else if (gun.gunSelection == 2)
                {
                    level4CompleteWithRifle = true;
                }
                break;
            case 5:
                if (gun.gunSelection == 0)
                {
                    level5CompleteWithPistol = true;
                }
                else if (gun.gunSelection == 1)
                {
                    level5CompleteWithShotgun = true;
                }
                else if (gun.gunSelection == 2)
                {
                    level5CompleteWithRifle = true;
                }
                break;
            default:
                break;
        }
    }
}
