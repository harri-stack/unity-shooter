using UnityEngine;
using UnityEngine.UI;
public class ChallengingButton : MonoBehaviour
{
    public UnityEngine.UI.Button Button;

    public void selectChallenge()
    {
        Gamedata.GameData.Difficulty = 3;
        Debug.Log("Challenging selected");
    }
}
