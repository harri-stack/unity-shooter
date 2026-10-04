using UnityEngine;
using TMPro;
public class Opponenthealthui : MonoBehaviour
{
    public GameObject HealthInfoObject;

    private TMP_Text healthText;

    private void Start()
    {
        healthText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        Health droneHealth = HealthInfoObject.GetComponent<Health>();

        healthText.text = "Health - " + droneHealth.health;

    }
}
