using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class HealthUI : MonoBehaviour
{
    public GameObject Player;
    public TMP_Text healthText;


    private void Update()
    {
        Playerhealth health = Player.GetComponent<Playerhealth>();
        healthText.text = "Health -  " + health.health;
    }

}
