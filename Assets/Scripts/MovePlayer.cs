using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f;
    [SerializeField] float gravity = -9.81f;
    [SerializeField] float jumpHeight = 3f;
    [SerializeField] LayerMask groundMask;
    Vector2 movementInput;
    Vector3 verticalVelocity = Vector3.zero;
    bool isGrounded;
    bool Jump;
    public void RecieveInput(Vector2 recievedMovementInput)
    {
        movementInput = recievedMovementInput;
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded == true)
        {
            verticalVelocity.y = 0;
        }
        Vector3 horizontalVelocity = (transform.right * movementInput.x + transform.forward * movementInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
        if (Jump == true)
        {
            if (isGrounded)
            {
                verticalVelocity.y = Mathf.Sqrt(-2 * jumpHeight * gravity);
            }
            Jump = false;
        }
        Jump = false;
        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }
    public void OnJumpPressed()
    {
        Jump = true;
    }
}
