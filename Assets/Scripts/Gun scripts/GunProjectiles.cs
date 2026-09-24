using UnityEngine;
using UnityEngine.InputSystem;

public class GunProjectiles : MonoBehaviour
{

    private void resetCoolDown()
    {
        Cooldown = false;
    }

    bool Cooldown = false;
    public GameObject Bullet;
    public GameObject bulletSpawn;
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && Cooldown == false)
        {
            Cooldown = true;
            Debug.Log("LOCAL: " + bulletSpawn.transform.localPosition);
            Debug.Log("WORLD: " + bulletSpawn.transform.position);
            Instantiate(Bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            GetComponent<AudioSource>().Play();

            Invoke(nameof(resetCoolDown), 0.4f);
        }
    }
}
