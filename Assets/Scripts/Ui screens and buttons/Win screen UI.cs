using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class WinscreenUI : MonoBehaviour
{
    public UnityEngine.UI.Button retryButton;

    public void Retry()
    {
        Debug.Log("Retry button pressed");
        SceneManager.LoadScene("DifficultyMenu");
    }
}
