using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;



    void Update() {
        if(Input.GetKey(KeyCode.Tab)) {
            LoadMainmenu();
        }
        if(Input.GetKey(KeyCode.Escape)) {
            Quit();
        }
    }

    public void LoadMainmenu() {
        SceneManager.LoadScene(0);
    }
    public void NextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EndGame() {
        if(gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("Restart", 1f);
            
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit() {
        Application.Quit();
    }
}
