using UnityEngine;

public class Opponentbullets : MonoBehaviour
{
    Rigidbody rigidBody;
    public int Damage = 10;
    private void destroyBullet()
    {
        Destroy(gameObject);
    }

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        Debug.Log("Bullet fired");
        rigidBody.linearVelocity = transform.forward * 50f;

        Invoke(nameof(destroyBullet), 2f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Playerhealth Player = collision.gameObject.GetComponent<Playerhealth>();

        if (Player != null)
        {
            Debug.Log("Player took " + Damage + " damage!");
            destroyBullet();
            Player.takeDamage(Damage);
        }
    }
}
