using UnityEngine;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D player;
    public GameObject GOUI;

    public int lives;
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;

    public bool grounded = true;

    private void Awake() {
        Debug.Log("dfasfd");
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        float input =  Input.GetAxis("Horizontal");

        // flip on x-axis
        if(input > 0.01f) 
            transform.localScale = new Vector3(-0.1f, 0.1f, 1);
        else if(input < -0.01f) {
            transform.localScale = new Vector3(0.1f, 0.1f, 1);
        }

        player.velocity = new Vector2(input * speed, player.velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded) {
            Jump();
        }
        if(Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }

    public void Jump() {
        player.velocity = new Vector2(player.velocity.x * Time.deltaTime, jumpForce);
        grounded = false;
    }

    public void Success() {
        PlayerPrefs.SetFloat("score", PlayerPrefs.GetFloat("score") + player.gameObject.transform.position.y);
        player.constraints = RigidbodyConstraints2D.FreezeAll;
        FindObjectOfType<GameManagerScript>().NextLevel();
    }

    public void Die() {
        if(lives == 0) {
            GOUI.SetActive(true);
            player.constraints = RigidbodyConstraints2D.FreezeAll;
            FindObjectOfType<GameManagerScript>().EndGame(); 
        }
        lives -= 1;
    }
}