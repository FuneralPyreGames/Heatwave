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
}
