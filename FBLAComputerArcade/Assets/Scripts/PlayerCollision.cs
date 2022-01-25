using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private Rigidbody2D player;

    private void OnCollisionEnter2D(Collision2D collision) {
        player = movement.player;
        
        // If the player hits the top side of the ground
        if(collision.gameObject.tag == "Ground") {
            float colliderTopPosition = collision.gameObject.transform.position.y + collision.gameObject.transform.localScale.y / 2;
            float playerBottomPosition = player.transform.position.y - player.transform.localScale.y / 2;

            if(playerBottomPosition > colliderTopPosition) {
                movement.grounded = true;
                movement.Jump();
            }
        }
        
        // If player hits an obstacle
        if(collision.gameObject.tag == "Obstacle") {
            movement.Die();
        }
    }
}
