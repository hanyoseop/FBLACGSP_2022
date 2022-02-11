using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public float initialDirection;
    void FixedUpdate()
    {
        transform.Translate(new Vector2(1f, 0) * speed * Time.deltaTime * initialDirection);
    }

    // Deletes itself when hit the walls
    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Wall") {
            Destroy(gameObject);
        }
    }
}
