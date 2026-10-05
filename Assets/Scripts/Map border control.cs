using UnityEngine;

public class Mapbordercontrol : MonoBehaviour
{
    public GameObject deathScreen;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLISION WITH: " + other.name);
        Playerhealth player = other.GetComponent<Playerhealth>();

        if (player != null)
        {
            deathScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None; Cursor.visible = true;
            deathScreen.GetComponent<AudioSource>().Play();
            gameObject.SetActive(false);
        }
    }
}
