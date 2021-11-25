using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    #region Variables
    [Header("Gun Select")]
    public string[] gunTypes = { "Pistol", "Shotgun", "Rifle" };
    public int gunSelection;
    [Header("Shot Attributes")]
    [SerializeField] float Range = 50f;
    [SerializeField] float Damage = 10f;
    [SerializeField] float reloadTime;
    [SerializeField] float inaccuracyDistance = 0f;
    [SerializeField] float fadeDuration = 0.3f;
    [Header("Assignables")]
    [SerializeField] GameObject laser;
    [SerializeField] PlayerDataController playerDataController;
    [SerializeField] Transform muzzle;
    [SerializeField] AmmoHandler ammoHandler;
    [Header("Not In Inspector")]
    Transform playerCamera;
    #endregion
    #region Starting Functions
    void Awake()
    {
        playerCamera = Camera.main.transform;
        ammoHandler.currentCarryAmmo = ammoHandler.startingCarryAmmo;
        ammoHandler.currentInGunAmmo = ammoHandler.startingInGunAmmo;
    }
    public void Shoot()
    {
        bool ableToShoot = ammoHandler.CheckAmmo();
        if (ableToShoot)
        {
            //This looks at what gun type the player has chose, and forwards them to the correct function for shooting
            if (gunSelection == 0)
            {
                PistolShootSelector();
            }
            if (gunSelection == 1)
            {
                ShotgunShootSelector();
            }
            if (gunSelection == 2)
            {
                RifleShootSelector();
            }
        }
    }
    #endregion
    #region Pistol
    // Damage = 20
    // Ammo = 6
    // Range = 20
    public void PistolShootSelector()
    {
        int currentHeat = playerDataController.currentHeat;
        switch(currentHeat)
        {
            case -3:
                PistolShotColdLevel3();
                break;
            case -2:
                PistolShotColdLevel2();
                break;
            case -1:
                PistolShotColdLevel1();
                break;
            case 0:
                PistolShotNeutral();
                break;
            case 1:
                PistolShotHotLevel1();
                break;
            case 2:
                PistolShotHotLevel2();
                break;
            case 3:
                PistolShotHotLevel3();
                break;
            default:
                break;
        }
    }
    public void PistolShotColdLevel3()
    {
        Range = 35f;
        Damage = 14f;
        inaccuracyDistance = 1.5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotColdLevel2()
    {
        Range = 30f;
        Damage = 16f;
        inaccuracyDistance = 1f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotColdLevel1()
    {
        Range = 25f;
        Damage = 18f;
        inaccuracyDistance = .5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotNeutral()
    {
        Range = 20f;
        Damage = 20f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotHotLevel1()
    {
        Range = 15f;
        Damage = 25f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotHotLevel2()
    {
        Range = 10f;
        Damage = 30f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void PistolShotHotLevel3()
    {
        Range = 5f;
        Damage = 35f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    #endregion
    #region Shotgun
    // Damage = 10
    // Ammo = 20
    // Range = 25
    public void ShotgunShootSelector()
    {
        //This uses the player data controller to figure out the current heat state, and then picks the correct gun firing function
        int currentHeat = playerDataController.currentHeat;
        switch (currentHeat)
        {
            case -3:
                ShotgunShotColdLevel3();
                break;
            case -2:
                ShotgunShotColdLevel2();
                break;
            case -1:
                ShotgunShotColdLevel1();
                break;
            case 0:
                ShotgunShotNeutral();
                break;
            case 1:
                ShotgunShotHotLevel1();
                break;
            case 2:
                ShotgunShotHotLevel2();
                break;
            case 3:
                ShotgunShotHotLevel3();
                break;
            default:
                break;
        }
    }
    //Being cold will give the gun
    //1. An increased range of inaccuracy
    //2. Lower levels of damage
    //3. A longer range
    public void ShotgunShotColdLevel3()
    {
        Range = 40;
        Damage = 5f;
        inaccuracyDistance = 1.5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void ShotgunShotColdLevel2()
    {
        Range = 35f;
        Damage = 7f;
        inaccuracyDistance = 1f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void ShotgunShotColdLevel1()
    {
        Range = 30f;
        Damage = 9f;
        inaccuracyDistance = .5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void ShotgunShotNeutral()
    {
        Range = 25f;
        Damage = 10f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }    
    //Being hot will give the gun
    //1. A small chance to not fire
    //2. Increased damage
    //3. A shorter range
    public void ShotgunShotHotLevel1()
    {
        Range = 20f;
        Damage = 11f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void ShotgunShotHotLevel2()
    {
        Range = 15f;
        Damage = 13f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void ShotgunShotHotLevel3()
    {
        Range = 10f;
        Damage = 15f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    #endregion
    #region Rifle
    // Damage = 15
    // Ammo = 10
    // Range = 35
    public void RifleShootSelector()
    {
        int currentHeat = playerDataController.currentHeat;
        switch(currentHeat)
        {
            case -3:
                RifleShotCold3();
                break;
            case -2:
                RifleShotCold2();
                break;
            case -1:
                RifleShotCold1();
                break;
            case 0:
                RifleShotNeutral();
                break;
            case 1:
                RifleShotHot1();
                break;
            case 2:
                RifleShotHot2();
                break;
            case 3:
                RifleShotHot3();
                break;
            default:
                break;
        }
    }
    public void RifleShotCold3()
    {
        Range = 50f;
        Damage = 9f;
        inaccuracyDistance = 1.5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotCold2()
    {
        Range = 45f;
        Damage = 11f;
        inaccuracyDistance = 1f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotCold1()
    {
        Range = 40f;
        Damage = 13f;
        inaccuracyDistance = .5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotNeutral()
    {
        Range = 35f;
        Damage = 15f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotHot1()
    {
        Range = 30f;
        Damage = 18f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotHot2()
    {
        Range = 25f;
        Damage = 21f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    public void RifleShotHot3()
    {
        Range = 20f;
        Damage = 25f;
        inaccuracyDistance = 0f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            if (hit.collider.GetComponent<DamageableObject>() != null)
            {
                hit.collider.GetComponent<DamageableObject>().TakeDamage(Damage, hit.point, hit.normal);
            }
            else if (hit.collider.tag == "Enemy")
            {
                hit.collider.GetComponent<EnemyHealth>().LoseHealth(Damage, hit.point, hit.normal);
            }
            CreateLaser(hit.point);
        }
        else
        {
            CreateLaser(playerCamera.position + shootingDir * Range);
        }
    }
    #endregion
    #region GeneralFunctions
    Vector3 GetShootingDirection()
    {
        Vector3 targetPos = playerCamera.position + playerCamera.forward * Range;
        targetPos = new Vector3(targetPos.x + Random.Range(-inaccuracyDistance, inaccuracyDistance), targetPos.y + Random.Range(-inaccuracyDistance, inaccuracyDistance), targetPos.z + Random.Range(-inaccuracyDistance, inaccuracyDistance));
        Vector3 direction = targetPos - playerCamera.position;
        return direction.normalized;
    }
    void CreateLaser(Vector3 endPos)
    {
        GameObject laserMade = Instantiate(laser);
        LineRenderer lr = laserMade.GetComponent<LineRenderer>();
        lr.SetPositions(new Vector3[2] { muzzle.position, endPos });
        StartCoroutine(FadeLaser(lr, laserMade));
    }
    #endregion
    #region GeneralCoroutines
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
    #endregion
}