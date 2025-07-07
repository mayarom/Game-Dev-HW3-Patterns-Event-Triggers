using UnityEngine;

/**
 * This component continuously updates the on-screen score display
 * to reflect the current value of GAME_STATUS.playerScore.
 */
[RequireComponent(typeof(NumberField))]
public class GameStatusReader : MonoBehaviour {
    private NumberField numberField;
    private int lastKnownScore = -1;

    void Start() {
        numberField = GetComponent<NumberField>();
    }

    void Update() {
        // Update only if the score changed
        if (GAME_STATUS.playerScore != lastKnownScore) {
            lastKnownScore = GAME_STATUS.playerScore;
            numberField.SetNumber(lastKnownScore);
        }
    }
}
