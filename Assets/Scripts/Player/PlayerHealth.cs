using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int maxHealth = 100;
    int currentHealth;
    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void LoseHealth(int healthToLose)
    {
        currentHealth -= healthToLose;
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        print("You Died");
    }
}
