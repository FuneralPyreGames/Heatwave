using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 100;
    [SerializeField] float currentHealth;
    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void LoseHealth(float healthToLose)
    {
        currentHealth -= healthToLose;
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        Destroy(gameObject);
    }
}