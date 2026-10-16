using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class NormalButton : MonoBehaviour
{
    public UnityEngine.UI.Button Button;

    public void selectNormal()
    {
        Gamedata.GameData.Difficulty = 2;
        Debug.Log("Normal selected");
        SceneManager.LoadScene("SampleScene");
    }
    
}
