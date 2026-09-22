using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController characterController;
    public float Speed = 3.5f;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
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
        characterController.Move(finalDirection * Time.deltaTime);
    }
}
