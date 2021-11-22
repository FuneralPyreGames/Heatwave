using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionBriefing : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemies;
    public GameObject missionBriefing;
    public Gun gun;
    public void LoadViaShotgun()
    {        
        Player.SetActive(true);
        Enemies.SetActive(true);          
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayRandomSong();
        gun.gunSelection = 1;
        missionBriefing.SetActive(false);
    }
    public void Exit()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        SceneChangeManager sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        sceneChangeManager.LoadLevel("MainMenu");
    }
}
