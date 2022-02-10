using UnityEngine;

public class LogScript : MonoBehaviour
{
    public Rigidbody2D log;

    [SerializeField] private float speed;
    [SerializeField] private float initalDirection;
    private float direction;
    private float counter = 0;

    void Start() {
        direction = initalDirection;
    }

    void FixedUpdate() {
        log.velocity = new Vector2(direction * Time.deltaTime * speed, log.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "StartingGround" || collision.gameObject.tag == "Obstacle" || collision.gameObject.name == "Player") {
            FindObjectOfType<AudioManager>().Play("LogBreaking");
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Ground") {
            ChangeDirection();
        }
    }

    private void ChangeDirection() {
        if(counter == 0) {
            direction = initalDirection;
            counter += 1;
        }
        else if(Random.Range(-1f, 1f) >= 0) {
            direction = -1f;
        } 
        else {
            direction = 1f;
        }
    }


}
