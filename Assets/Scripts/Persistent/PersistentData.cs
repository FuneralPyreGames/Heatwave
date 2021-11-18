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
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    public void ResetGame()
    {
        level1CompleteWithPistol = false;
        level1CompleteWithRifle = false;
        level1CompleteWithShotgun = false;
    }
}
