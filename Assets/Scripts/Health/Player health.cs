using UnityEngine;

public class Playerhealth : MonoBehaviour
{
   public int health = 100;
    public GameObject deathScreen;
    
    public void takeDamage(int Damage)
    {
        health = health - Damage;
        if (health < 1)
        {
            deathScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
            deathScreen.GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
        }
    }
}
