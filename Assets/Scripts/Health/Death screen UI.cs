using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class DeathscreenUI : MonoBehaviour
{
    public Button retryButton;

    public void Retry()
    {
        Debug.Log("Retry button pressed");
        Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
