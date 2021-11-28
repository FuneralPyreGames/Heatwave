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
}
