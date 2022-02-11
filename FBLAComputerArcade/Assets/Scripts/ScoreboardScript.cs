using UnityEngine;
using UnityEngine.UI;

public class ScoreboardScript : MonoBehaviour
{
    public Text lvl1score, lvl2score, lvl3score;

    void Awake() {
        // Inital update
        updateScoreboard();
    }

    // Update scoreboard function
    void updateScoreboard() {
        lvl1score.text = PlayerPrefs.GetFloat("lvl1Score", 0).ToString("0");
        lvl2score.text = PlayerPrefs.GetFloat("lvl2Score", 0).ToString("0");
        lvl3score.text = PlayerPrefs.GetFloat("lvl3Score", 0).ToString("0");
    }

    // Update after reset
    public void resetScoreboard() {
        PlayerPrefs.SetFloat("lvl1Score", 0);
        PlayerPrefs.SetFloat("lvl2Score", 0);
        PlayerPrefs.SetFloat("lvl3Score", 0);
        updateScoreboard();
    }
}
