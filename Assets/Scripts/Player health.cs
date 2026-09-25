using UnityEngine;

public class Playerhealth : MonoBehaviour
{
    int health = 100;
    
    public void takeDamage(int Damage)
    {
        health = health - Damage;
        if (health < 1)
        {
            gameObject.SetActive(false);
        }
    }
}
