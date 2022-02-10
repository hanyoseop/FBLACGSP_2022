using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private Rigidbody2D player;
    public GameObject endingUI;

    private void OnCollisionEnter2D(Collision2D collision) {
        player = movement.player;
        
        if(collision.gameObject.name == "TopGround") {
            movement.Success();
        }

        if(collision.gameObject.name == "EndingGround") {
            endingUI.SetActive(true);
        }

        // If the player hits the top side of the ground
        if(collision.gameObject.tag == "Ground") {
            float colliderTopPosition = collision.gameObject.transform.position.y + collision.gameObject.transform.localScale.y / 2;
            float playerBottomPosition = player.transform.position.y - player.transform.localScale.y / 2;

            if(playerBottomPosition > colliderTopPosition) {
                movement.grounded = true;
                FindObjectOfType<AudioManager>().Play("Jumping");
                movement.Jump();
            }
        }

        if(collision.gameObject.name == "Death") {
            movement.Die();
        }
        
        // If player hits an obstacle
        if(collision.gameObject.tag == "Obstacle") {
            movement.Die();
        }
    }
}
