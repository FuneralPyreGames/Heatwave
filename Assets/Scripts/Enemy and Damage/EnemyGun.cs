using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    [SerializeField] float fadeDuration = 0.3f;
    [SerializeField] float Damage = 10f;
    [SerializeField] GameObject laser;
    [SerializeField] Transform muzzle;
    [SerializeField] float inaccuracyDistance = 0f;
    [SerializeField] float Range = 20f;

    public void Shoot()
    {
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(muzzle.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Player")
            {
                hit.collider.GetComponent<PlayerHealth>().LoseHealth(Damage);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(muzzle.position + shootingDir * Range);
        }
    }
    Vector3 GetShootingDirection()
    {
        Vector3 targetPos = muzzle.position + muzzle.forward * Range;
        targetPos = new Vector3(targetPos.x + Random.Range(-inaccuracyDistance, inaccuracyDistance), targetPos.y + Random.Range(-inaccuracyDistance, inaccuracyDistance), targetPos.z + Random.Range(-inaccuracyDistance, inaccuracyDistance));
        Vector3 direction = targetPos - muzzle.position;
        return direction.normalized;
    }
    void CreateLaser(Vector3 endPos)
    {
        GameObject laserMade = Instantiate(laser);
        LineRenderer lr = laserMade.GetComponent<LineRenderer>();
        lr.SetPositions(new Vector3[2] { muzzle.position, endPos });
        StartCoroutine(FadeLaser(lr, laserMade));
    }
    IEnumerator FadeLaser(LineRenderer lr, GameObject laserMade)
    {
        float Alpha = 1;
        while (Alpha > 0)
        {
            Alpha -= Time.deltaTime / fadeDuration;
            lr.startColor = new Color(lr.startColor.r, lr.startColor.g, lr.startColor.b, Alpha);
            lr.endColor = new Color(lr.endColor.r, lr.endColor.g, lr.endColor.b, Alpha);
            yield return null;
        }
        Destroy(laserMade);
    }
}
