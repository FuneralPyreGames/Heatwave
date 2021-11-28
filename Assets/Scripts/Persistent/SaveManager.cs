using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    //As a general guideline, 0 means that the level is not complete, and 1 means that it is complete
    //Also I probably could find a more efficient way to do this but I'd rather take the time hit then have to research that
    //naming covention is number of level followed by the gun type, "p" for pistol, "r" for rifle, "s" for shotgun
    public PersistentData persistentData;
    void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
    }
    public void SaveGame()
    {
        #region PistolSaving
        if (persistentData.level1CompleteWithPistol == true)
        {
            PlayerPrefs.SetInt("1P", 1);
        }
        else if (persistentData.level1CompleteWithPistol == false)
        {
            PlayerPrefs.SetInt("1P", 0);
        }
        if (persistentData.level2CompleteWithPistol == true)
        {
            PlayerPrefs.SetInt("2P", 1);
        }
        else if (persistentData.level2CompleteWithPistol == false)
        {
            PlayerPrefs.SetInt("2P", 0);
        }
        if (persistentData.level3CompleteWithPistol == true)
        {
            PlayerPrefs.SetInt("3P", 1);
        }
        else if (persistentData.level3CompleteWithPistol == false)
        {
            PlayerPrefs.SetInt("3P", 0);
        }
        if (persistentData.level4CompleteWithPistol == true)
        {
            PlayerPrefs.SetInt("4P", 1);
        }
        else if (persistentData.level4CompleteWithPistol == false)
        {
            PlayerPrefs.SetInt("4P", 0);
        }
        if (persistentData.level5CompleteWithPistol == true)
        {
            PlayerPrefs.SetInt("5P", 1);
        }
        else if (persistentData.level5CompleteWithPistol == false)
        {
            PlayerPrefs.SetInt("5P", 0);
        }
        #endregion
        #region RifleSaving
        if (persistentData.level1CompleteWithRifle == true)
        {
            PlayerPrefs.SetInt("1R", 1);
        }
        else if (persistentData.level1CompleteWithRifle == false)
        {
            PlayerPrefs.SetInt("1R", 0);
        }
        if (persistentData.level2CompleteWithRifle == true)
        {
            PlayerPrefs.SetInt("2R", 1);
        }
        else if (persistentData.level2CompleteWithRifle == false)
        {
            PlayerPrefs.SetInt("2R", 0);
        }
        if (persistentData.level3CompleteWithRifle == true)
        {
            PlayerPrefs.SetInt("3R", 1);
        }
        else if (persistentData.level3CompleteWithRifle == false)
        {
            PlayerPrefs.SetInt("3R", 0);
        }
        if (persistentData.level4CompleteWithRifle == true)
        {
            PlayerPrefs.SetInt("4R", 1);
        }
        else if (persistentData.level4CompleteWithRifle == false)
        {
            PlayerPrefs.SetInt("4R", 0);
        }
        if (persistentData.level5CompleteWithRifle == true)
        {
            PlayerPrefs.SetInt("5R", 1);
        }
        else if (persistentData.level5CompleteWithRifle == false)
        {
            PlayerPrefs.SetInt("5R", 0);
        }
        #endregion
        #region ShotgunSaving
        if (persistentData.level1CompleteWithShotgun == true)
        {
            PlayerPrefs.SetInt("1S", 1);
        }
        else if (persistentData.level1CompleteWithShotgun == false)
        {
            PlayerPrefs.SetInt("1S", 0);
        }
        if (persistentData.level2CompleteWithShotgun == true)
        {
            PlayerPrefs.SetInt("2S", 1);
        }
        else if (persistentData.level2CompleteWithShotgun == false)
        {
            PlayerPrefs.SetInt("2S", 0);
        }
        if (persistentData.level3CompleteWithShotgun == true)
        {
            PlayerPrefs.SetInt("3S", 1);
        }
        else if (persistentData.level3CompleteWithShotgun == false)
        {
            PlayerPrefs.SetInt("3S", 0);
        }
        if (persistentData.level4CompleteWithShotgun == true)
        {
            PlayerPrefs.SetInt("4S", 1);
        }
        else if (persistentData.level4CompleteWithShotgun == false)
        {
            PlayerPrefs.SetInt("4S", 0);
        }
        if (persistentData.level5CompleteWithShotgun == true)
        {
            PlayerPrefs.SetInt("5S", 1);
        }
        else if (persistentData.level5CompleteWithShotgun == false)
        {
            PlayerPrefs.SetInt("5S", 0);
        }
        #endregion
        #region OtherSaving
        PlayerPrefs.SetInt("Last Level", persistentData.lastCompletedLevel);
        #endregion
    }
    public void ResetSaves()
    {
        PlayerPrefs.SetInt("1P", 0);
        PlayerPrefs.SetInt("2P", 0);
        PlayerPrefs.SetInt("3P", 0);
        PlayerPrefs.SetInt("4P", 0);
        PlayerPrefs.SetInt("5P", 0);
        PlayerPrefs.SetInt("1R", 0);
        PlayerPrefs.SetInt("2R", 0);
        PlayerPrefs.SetInt("3R", 0);
        PlayerPrefs.SetInt("4R", 0);
        PlayerPrefs.SetInt("5R", 0);
        PlayerPrefs.SetInt("1S", 0);
        PlayerPrefs.SetInt("2S", 0);
        PlayerPrefs.SetInt("3S", 0);
        PlayerPrefs.SetInt("4S", 0);
        PlayerPrefs.SetInt("5S", 0);
        PlayerPrefs.SetInt("Last Level", 0);
    }
}
