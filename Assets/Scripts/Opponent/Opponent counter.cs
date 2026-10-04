using Unity.VisualScripting;
using UnityEngine;

public class Opponentcounter : MonoBehaviour
{
    public int livingOpponents = 2;
    public AudioSource winSound;
    public GameObject winScreen;
    public void opponentDied()
    {
        livingOpponents = livingOpponents - 1;
        if(livingOpponents == 0)
        {
            winScreen.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.None; UnityEngine.Cursor.visible = true;
            winSound.Play();
        }
    }
}
