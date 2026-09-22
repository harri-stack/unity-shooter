using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    public float Speed = 3.5f;
    public float Gravity = 9.5f;
    public float jumpHeight = 2f;
    private float yVelocity;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && characterController.isGrounded)
        {
            yVelocity = Mathf.Sqrt(jumpHeight * 2f * Gravity);
        }


        if (characterController.isGrounded && yVelocity < 0)
        {
            yVelocity = -2f;
        }

        yVelocity -= Gravity * Time.deltaTime;
        Vector3 Direction = Vector3.zero;

        if (Keyboard.current.wKey.isPressed)
        {
            Direction -= transform.forward;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Direction += transform.forward;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Direction += transform.right;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Direction -= transform.right;
        }

        if (Keyboard.current.leftShiftKey.isPressed)
        {
            Speed = 7.0f;
        }
        else
        {
            Speed = 3.5f;
        }

        Direction = Direction.normalized;
        Vector3 finalDirection = Direction * Speed;
        finalDirection.y = yVelocity;
        characterController.Move(finalDirection * Time.deltaTime);
    }
}
