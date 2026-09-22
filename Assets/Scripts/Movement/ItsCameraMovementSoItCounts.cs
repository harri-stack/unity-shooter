using UnityEngine;
using UnityEngine.InputSystem;

public class ItsCameraMovementSoItCounts : MonoBehaviour
{
    public float Sensitivity = 200f;

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Vector2 mouse = Mouse.current.delta.ReadValue();

        float mouseX = mouse.x * Sensitivity * Time.deltaTime;
        float mouseY = mouse.y * Sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 180f, 0f);

        transform.parent.Rotate(Vector3.up * mouseX);
    }
}