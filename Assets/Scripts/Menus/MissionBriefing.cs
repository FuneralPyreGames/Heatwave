using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionBriefing : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemies;
    public GameObject missionBriefing;
    public Gun gun;
    public AmmoHandler ammoHandler;
    public void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayMissionBriefingMusic();
    }
    public void LoadViaShotgun()
    {        
        Player.SetActive(true);
        Enemies.SetActive(true);          
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayRandomSong();
        gun.gunSelection = 1;
        ammoHandler.SetAmmo(20);
        missionBriefing.SetActive(false);
    }
    public void LoadViaPistol()
    {        
        Player.SetActive(true);
        Enemies.SetActive(true);          
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayRandomSong();
        gun.gunSelection = 0;
        ammoHandler.SetAmmo(6);
        missionBriefing.SetActive(false);
    }
    public void LoadViaRifle()
    {        
        Player.SetActive(true);
        Enemies.SetActive(true);          
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        Audio Audio = persistentComponents.GetComponent<Audio>();
        Audio.PlayRandomSong();
        gun.gunSelection = 2;
        ammoHandler.SetAmmo(10);
        missionBriefing.SetActive(false);
    }
    public void Exit()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        SceneChangeManager sceneChangeManager = persistentComponents.GetComponent<SceneChangeManager>();
        sceneChangeManager.LoadLevel("MainMenu");
    }
}
