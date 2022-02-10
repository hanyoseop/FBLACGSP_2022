using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
   public Transform player;
   public PlayerMovement movement;
   public Text scoreText, lifeText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score: " + (player.position.y * 100).ToString("0");
        lifeText.text = "Life: " + movement.lives.ToString();
    }
}
