using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header("Gun Select")]
    [SerializeField] string[] gunTypes = { "Pistol", "Shotgun", "Rifle" };
    [SerializeField] int gunSelection;
    [Header("Shot Attributes")]
    [SerializeField] float Range = 50f;
    [SerializeField] float Damage = 10f;
    [SerializeField] float fireRate = 5f;
    [SerializeField] float reloadTime;
    [SerializeField] float inaccuracyDistance = 0f;
    [SerializeField] float fadeDuration = 0.3f;
    [Header("Shotgun Settings")]
    [SerializeField] bool rapidFire = true;
    [Header("Assignables")]
    [SerializeField] GameObject laser;
    [SerializeField] PlayerDataController playerDataController;
    [SerializeField] Transform muzzle;
    [SerializeField] AmmoHandler ammoHandler;
    [Header("Not In Inspector")]
    Transform playerCamera;
    void Awake()
    {
        playerCamera = Camera.main.transform;
        ammoHandler.currentCarryAmmo = ammoHandler.startingCarryAmmo;
        ammoHandler.currentInGunAmmo = ammoHandler.startingInGunAmmo;
    }
    public void Shoot()
    {
        //This looks at what gun type the player has chose, and forwards them to the correct function for shooting
        if (gunSelection == 1)
        {
            ShotgunShootSelector();
        }
    }
    #region Shotgun
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
        Range = 65f;
        Damage = 5f;
        inaccuracyDistance = 1.5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotColdLevel2()
    {
        Range = 60f;
        Damage = 7f;
        inaccuracyDistance = 1f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotColdLevel1()
    {
        Range = 55f;
        Damage = 9f;
        inaccuracyDistance = .5f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotNeutral()
    {
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }    
    //Being hot will give the gun
    //1. A small chance to not fire
    //2. Increased damage
    //3. A shorter range
    public void ShotgunShotHotLevel1()
    {
        Range = 45f;
        Damage = 11f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotHotLevel2()
    {
        Range = 40f;
        Damage = 13f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotHotLevel3()
    {
        Range = 35f;
        Damage = 15f;
        ammoHandler.DecrementGunAmmo();
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
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
        LineRenderer lr = Instantiate(laser).GetComponent<LineRenderer>();
        lr.SetPositions(new Vector3[2] { muzzle.position, endPos });
        StartCoroutine(FadeLaser(lr));
    }
    #endregion
    #region GeneralCoroutines
    IEnumerator FadeLaser(LineRenderer lr)
    {
        float Alpha = 1;
        while (Alpha > 0)
        {
            Alpha -= Time.deltaTime / fadeDuration;
            lr.startColor = new Color(lr.startColor.r, lr.startColor.g, lr.startColor.b, Alpha);
            lr.endColor = new Color(lr.endColor.r, lr.endColor.g, lr.endColor.b, Alpha);
            yield return null;
        }
    }
    #endregion
}
