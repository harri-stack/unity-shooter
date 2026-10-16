using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ChallengingButton : MonoBehaviour
{
    public UnityEngine.UI.Button Button;

    public void selectChallenge()
    {
        Gamedata.GameData.Difficulty = 3;
        Debug.Log("Challenging selected");
        SceneManager.LoadScene("SampleScene");
    }
}
