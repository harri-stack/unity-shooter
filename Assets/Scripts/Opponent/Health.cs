using System;
using Unity.Mathematics;
using UnityEngine;
public class Health : MonoBehaviour
{
    public int health = 100;
    public GameObject Bullet;
    public GameObject bulletSpawn;
    public GameObject bulletSpawn2;
    public GameObject DeathSoundContainer;
    public GameObject HitSoundContainer;
    public void takeDamage(int Damage)
    {
        HitSoundContainer.GetComponent<AudioSource>().Play();
        health = health - Damage;
        if (health < 1)
        {
            DeathSoundContainer.GetComponent<AudioSource>().Play();
            Opponentcounter opponentCounter = HitSoundContainer.GetComponent<Opponentcounter>();
            opponentCounter.opponentDied();
            Destroy(gameObject);
            Debug.Log("Drone died");
        }
    }

    private void Update()
    {
        float shootOdds = 1f * Time.deltaTime;
        if (UnityEngine.Random.value < shootOdds)
        {
            int chosenGun = UnityEngine.Random.Range(0, 3);

            if (chosenGun == 1)
            {
                Instantiate(Bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            }
            else
            {
                Instantiate(Bullet, bulletSpawn2.transform.position, bulletSpawn2.transform.rotation);
            }
            Debug.Log("Fire in the hole");
            GetComponent<AudioSource>().Play();
        }
    }
}
