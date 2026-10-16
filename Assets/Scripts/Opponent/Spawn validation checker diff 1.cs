using UnityEngine;

public class Spawnvalidationcheckerdiff1 : MonoBehaviour
{
    private void Start()
    {
        if (Gamedata.GameData.Difficulty == 1)
        {
            gameObject.SetActive(false);
        }
    }
}
