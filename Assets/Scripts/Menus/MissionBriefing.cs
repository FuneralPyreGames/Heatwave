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
        missionBriefing.SetActive(false);
        gun.gunSelection = 1;
    }
}
