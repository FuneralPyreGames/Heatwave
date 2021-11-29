using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    [SerializeField] float maxHealth = 100f;
    [SerializeField] float currentHealth;
    [SerializeField] GameObject hitEffect;
    [SerializeField] Audio Audio;
    void Awake()
    {
        currentHealth = maxHealth;
        Audio = GameObject.Find("PersistentComponents(Clone)").GetComponent<Audio>();
    }
    public void TakeDamage(float Damage, Vector3 hitPos, Vector3 hitNormal)
    {
        Instantiate(hitEffect, hitPos, Quaternion.LookRotation(hitNormal));
        currentHealth -= Damage;
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Audio.PlaySomethingBrokenSFX();
        Destroy(gameObject);
    }
}
