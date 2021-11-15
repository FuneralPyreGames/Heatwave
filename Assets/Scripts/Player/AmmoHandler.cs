using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AmmoHandler : MonoBehaviour
{
    //This script handles the ammo of the gun
    public int maxInGunAmmo = 20;
    public int currentInGunAmmo;
    public int maxCarryAmmo = 100;
    public int currentCarryAmmo;
    public int startingInGunAmmo;
    public int startingCarryAmmo;
    public void DecrementGunAmmo()
    {
        currentInGunAmmo -= 1;
    }
}
