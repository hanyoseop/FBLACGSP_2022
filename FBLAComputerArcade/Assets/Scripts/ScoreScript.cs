using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{
   public Transform player;
   public PlayerMovement movement;

   public float totalScore;
   public float timeStart;
   public Text scoreText, lifeText;

    void Awake() {
        totalScore = 15000;
    }

    void Update()
    {
        // Start a timer
        timeStart += Time.deltaTime;
        totalScore -= timeStart / 100;
        
        // Check is player ran out of score
        if (totalScore <= 0) {
            movement.GameOver();
        }

        scoreText.text = "score: " + totalScore.ToString("0");
        lifeText.text = "Life: " + movement.lives.ToString();
    }

    public void ObstacleHit() {
        totalScore -= 1000f;
    }

    public void SaveScore() {
        // Save highscores to PlayerPref
        if(SceneManager.GetActiveScene().buildIndex == 1 && totalScore > PlayerPrefs.GetFloat("lvl1Score")) {
            PlayerPrefs.SetFloat("lvl1Score", totalScore);
        } else if (SceneManager.GetActiveScene().buildIndex == 2 && totalScore > PlayerPrefs.GetFloat("lvl2Score")) {
            PlayerPrefs.SetFloat("lvl2Score", totalScore);
        } else if (SceneManager.GetActiveScene().buildIndex == 3 && totalScore > PlayerPrefs.GetFloat("lvl3Score")) {
            PlayerPrefs.SetFloat("lvl3Score", totalScore);
        }
            
    }
}
