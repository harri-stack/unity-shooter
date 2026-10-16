using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BulletMovement : MonoBehaviour
{
    Rigidbody rigidBody;
    public int Damage = 0;

    private void Start()
    {
        if (Gamedata.GameData.Difficulty == 1)
        {
            Damage = 20;
        }
        else
        {
            if (Gamedata.GameData.Difficulty == 2)
            {
                Damage = 15;
            }
            else
            {
                if (Gamedata.GameData.Difficulty == 3)
                {
                    Damage = 10;
                }
            }

        }
    }
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

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I hit " + collision.gameObject.name);
        Health drone = collision.gameObject.GetComponent<Health>();

        if (drone != null)
        {
            Debug.Log("Drone took " + Damage + " damage!");
            destroyBullet();
            drone.takeDamage(Damage);
        }
    }
}