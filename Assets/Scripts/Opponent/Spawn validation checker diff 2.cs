using UnityEngine;

public class Spawnvalidationcheckerdiff2 : MonoBehaviour
{
    private void Start()
    {
        if (Gamedata.GameData.Difficulty == 1 || Gamedata.GameData.Difficulty == 2)
        {
            gameObject.SetActive(false);
        }
    }
}
