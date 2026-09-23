using UnityEngine;
using UnityEngine.InputSystem;

public class GunLerps : MonoBehaviour
{
    public float swayAmount = 0.05f;
    public float swaySpeed = 8f;

    public float bobAmount = 0.03f;
    public float bobSpeed = 8f;

    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private float bobTimer;

    void Start()
    {
        originalPosition = transform.localPosition;
        originalRotation = transform.localRotation;
    }

    void Update()
    {
        Vector2 mouse = Mouse.current.delta.ReadValue();

        float swayX = -mouse.x * swayAmount;
        float swayY = -mouse.y * swayAmount;

        Quaternion targetRotation = originalRotation * Quaternion.Euler(swayY, swayX, 0f);

        transform.localRotation = Quaternion.Lerp(
            transform.localRotation,
            targetRotation,
            swaySpeed * Time.deltaTime
        );

        bool moving =
            Keyboard.current.wKey.isPressed ||
            Keyboard.current.aKey.isPressed ||
            Keyboard.current.sKey.isPressed ||
            Keyboard.current.dKey.isPressed;

        if (moving)
        {
            bobTimer += Time.deltaTime * bobSpeed;

            float bobX = Mathf.Sin(bobTimer) * bobAmount;
            float bobY = Mathf.Abs(Mathf.Cos(bobTimer)) * bobAmount;

            Vector3 targetPosition =
                originalPosition + new Vector3(bobX, bobY, 0f);

            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                targetPosition,
                10f * Time.deltaTime
            );
        }
        else
        {
            bobTimer = 0f;

            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                originalPosition,
                10f * Time.deltaTime
            );
        }
    }
}