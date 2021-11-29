using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float maxHealth = 100;
    [SerializeField] float currentHealth;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Audio Audio;
    void Awake()
    {
        currentHealth = maxHealth;
        Audio = GameObject.Find("PersistentComponents(Clone)").GetComponent<Audio>();
    }
    public void LoseHealth(float healthToLose, Vector3 hitPos, Vector3 hitNormal)
    {
        Audio.PlayEnemyHitSFX();
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
