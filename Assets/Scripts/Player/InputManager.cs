using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    PlayerMovement controls;
    [SerializeField] MovePlayer movePlayer;
    [SerializeField] Look look;
    [SerializeField] Gun gun;
    [SerializeField] AmmoHandler ammoHandler;
    [SerializeField] GameObject pauseMenu;
    PlayerMovement.MovementActions movementActions;
    PlayerMovement.GunplayActions gunplayActions;
    Vector2 movementInput;
    Vector2 lookInput;
    void Awake()
    {
        // This code checks the state of the actions in Unity's new input system. It will then either get the correct value or trigger the correct function
        controls = new PlayerMovement();
        movementActions = controls.Movement;
        gunplayActions = controls.Gunplay;
        movementActions.GroundMovement.performed += ctx => movementInput = ctx.ReadValue<Vector2>();
        movementActions.Jump.performed += _ => movePlayer.OnJumpPressed();
        movementActions.LookX.performed += ctx => lookInput.x = ctx.ReadValue<float>();
        movementActions.LookY.performed += ctx => lookInput.y = ctx.ReadValue<float>();
        movementActions.Sprint.started += _ => StartSprint();
        movementActions.Sprint.canceled += _ => EndSprint();
        movementActions.Pause.performed += _ => Pause();
        gunplayActions.Shoot.performed += _ => gun.Shoot();
        gunplayActions.Reload.performed += _ => ammoHandler.Reload();
    }
    void Update()
    {
        //This is where input that requires context is handled
        movePlayer.RecieveInput(movementInput);
        look.RecieveInput(lookInput);
    }
    void StartSprint()
    {
        movePlayer.StartSprint();
    }
    void EndSprint()
    {
        movePlayer.StopSprint();
    }
    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }
    private void Pause()
    {
        pauseMenu.SetActive(true);
    }
}