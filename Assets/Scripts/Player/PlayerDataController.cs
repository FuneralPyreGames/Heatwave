using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataController : MonoBehaviour
{
    public int currentHeat;
    // -3 is Cold Level 3
    // -2 is Cold Level 2
    // -1 is Cold Level 1
    // 0 is Neutral
    // 1 is Hot Level 1
    // 2 is Hot Level 2
    // 3 is Hot Level 3
    private void OnTriggerEnter(Collider other)
    {
        HeatSetter hs = other.GetComponent<HeatSetter>();
        currentHeat = hs.currentHeat;
        print(currentHeat);
    }
}
