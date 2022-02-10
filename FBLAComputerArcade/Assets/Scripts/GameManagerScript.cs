using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;

    public void LoadScene(int sceneNumber) {
        SceneManager.LoadScene(sceneNumber);
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
}
