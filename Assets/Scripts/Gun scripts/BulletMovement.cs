using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    Rigidbody rigidBody;

    private void destroyBullet()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        Debug.Log("Bullet fired");
        rigidBody.linearVelocity = transform.forward * 75f;

        Invoke(nameof(destroyBullet), 2f);
    }
}