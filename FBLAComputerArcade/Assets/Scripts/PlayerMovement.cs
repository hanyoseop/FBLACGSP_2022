using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;

    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    public bool grounded = true;

    private void Awake() {
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        player.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, player.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded) {
            Jump();
        }
    }

    public void Jump() {
        player.velocity = new Vector2(player.velocity.x * Time.deltaTime, jumpForce);
        grounded = false;
    }

    public void Die() {
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        FindObjectOfType<GameManagerScript>().EndGame();
    }
}