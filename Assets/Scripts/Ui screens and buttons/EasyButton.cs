using UnityEngine;

public class EasyButton : MonoBehaviour
{

    public UnityEngine.UI.Button Button;

    public void selectEasy()
    {
        Gamedata.GameData.Difficulty = 1;
        Debug.Log("Easy selected");
    } 
}
