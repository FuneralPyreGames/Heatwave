using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 100;
    [SerializeField] float currentHealth;
    [SerializeField] GameObject hitEffect;
    void Awake()
    {
        currentHealth = maxHealth;
    }
    public void LoseHealth(float healthToLose, Vector3 hitPos, Vector3 hitNormal)
    {
        Instantiate(hitEffect, hitPos, Quaternion.LookRotation(hitNormal));
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
