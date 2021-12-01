using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    [SerializeField] float sensitivityX = 100f;
    [SerializeField] float sensitivityY = 0.5f;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0;
    float LookX;
    float LookY;
    [SerializeField] Transform playerCamera;
    public PersistentData persistentData;
    void Awake()
    {
        GameObject persistentComponents = GameObject.Find("PersistentComponents(Clone)");
        persistentData = persistentComponents.GetComponent<PersistentData>();
        sensitivityX = persistentData.xSensitivity;
        sensitivityY = persistentData.ySensitivity;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void RecieveInput(Vector2 recievedInput)
    {
        LookX = recievedInput.x * sensitivityX;
        LookY = recievedInput.y * sensitivityY;
    }
    void Update()
    {
        transform.Rotate(Vector3.up, LookX * Time.deltaTime);
        xRotation -= LookY;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.eulerAngles = targetRotation;
    }
}