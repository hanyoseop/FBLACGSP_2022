using UnityEngine;

public class LogScript : MonoBehaviour
{
    public Rigidbody2D log;

    [SerializeField] private float speed;
    private float direction;

    void Start() {
        ChangeDirection();
    }

    void FixedUpdate() {
        log.velocity = new Vector2(direction * Time.deltaTime * speed, log.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "StartingGround") {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Ground") {
            ChangeDirection();
        }
    }

    private void ChangeDirection() {
        if(Random.Range(-1f, 1f) >= 0) {
            direction = -1f;
        } 
        else {
            direction = 1f;
        }
    }


}
