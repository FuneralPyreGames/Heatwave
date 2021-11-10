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
    [SerializeField] float innacuracyDistance = 5f;
    [SerializeField] float fadeDuration = 0.3f;
    [Header("Shotgun Settings")]
    [SerializeField] bool rapidFire = true;
    [Header("Ammo")]
    [SerializeField] int maxInGunAmmo = 20;
    [SerializeField] int currentInGunAmmo;
    [SerializeField] int maxCarryAmmo = 100;
    [SerializeField] int currentCarryAmmo;
    [SerializeField] int startingInGunAmmo;
    [SerializeField] int startingCarryAmmo;
    [Header("Assignables")]
    [SerializeField] GameObject laser;
    [SerializeField] PlayerDataController playerDataController;
    [SerializeField] Transform muzzle;
    [Header("Not In Inspector")]
    Transform playerCamera;
    void Awake()
    {
        playerCamera = Camera.main.transform;
        currentCarryAmmo = startingCarryAmmo;
        currentInGunAmmo = startingInGunAmmo;
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
    public void ShotgunShotColdLevel3()
    {

    }
    public void ShotgunShotColdLevel2()
    {

    }
    public void ShotgunShotColdLevel1()
    {

    }
    public void ShotgunShotNeutral()
    {
        currentInGunAmmo -= 1;
        Vector3 shootingDir = GetShootingDirection();
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.position, shootingDir, out hit, Range))
        {
            CreateLaser(hit.point);
        }
    }
    public void ShotgunShotHotLevel1()
    {

    }
    public void ShotgunShotHotLevel2()
    {

    }
    public void ShotgunShotHotLevel3()
    {

    }
    #endregion
    #region GeneralFunctions
    Vector3 GetShootingDirection()
    {
        Vector3 targetPos = playerCamera.position + playerCamera.forward * Range;
        targetPos = new Vector3(targetPos.x + Random.Range(-innacuracyDistance, innacuracyDistance), targetPos.y + Random.Range(-innacuracyDistance, innacuracyDistance), targetPos.z + Random.Range(-innacuracyDistance, innacuracyDistance));
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
