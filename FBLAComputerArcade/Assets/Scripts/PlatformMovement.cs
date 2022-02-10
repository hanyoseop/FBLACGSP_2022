using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed;
    private float direction;
    void Awake()
    {
        speed = speed * Random.Range(0.2f, 1f);
        if(Random.Range(-1f, 1f) >= 0) {
            direction = -1f;
        } 
        else {
            direction = 1f;
        }
    }

    void FixedUpdate()
    {
        transform.Translate(new Vector2(1f, 0) * speed * Time.deltaTime * direction);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Wall") {
            changeDirection();
        }
    }

    void changeDirection() {
        direction = -direction;
    }
}
