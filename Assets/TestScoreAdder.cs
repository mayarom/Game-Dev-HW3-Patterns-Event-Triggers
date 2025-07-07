using UnityEngine;

public class TestScoreAdder : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GAME_STATUS.playerScore += 1;
            Debug.Log("Score: " + GAME_STATUS.playerScore);
        }
    }
}
