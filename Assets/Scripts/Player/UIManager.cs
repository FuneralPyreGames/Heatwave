using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI inGunAmmoText;
    public TextMeshProUGUI carryAmmoText;
    public TextMeshProUGUI healthText;
    public void UpdateHealthText(float healthToUpdate)
    {
        healthText.text = "Current Health = ";
        healthText.text += healthToUpdate;
    }
    public void UpdateInGunAmmoText(int inGunAmmo)
    {
        inGunAmmoText.text = "Current In Gun Ammo = ";
        inGunAmmoText.text += inGunAmmo;
    }
    public void UpdateCarryAmmoText(int carryAmmo)
    {
        inGunAmmoText.text = "Current Carry Ammo = ";
        inGunAmmoText.text += carryAmmo;
    }
}
