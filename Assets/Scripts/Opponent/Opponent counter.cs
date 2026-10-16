using Unity.VisualScripting;
using UnityEngine;

public class Opponentcounter : MonoBehaviour
{
    private int livingOpponents = Gamedata.GameData.Difficulty;
    public AudioSource winSound;
    public GameObject winScreen;
    public void opponentDied()
    {
        Debug.Log("Living opponents = " + livingOpponents);
        livingOpponents = livingOpponents - 1;
        if(livingOpponents == 0)
        {
            winScreen.SetActive(true);
            UnityEngine.Cursor.lockState = CursorLockMode.None; UnityEngine.Cursor.visible = true;
            winSound.Play();
        }
    }
}
