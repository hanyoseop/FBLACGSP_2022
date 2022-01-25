using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame() {
        if(gameHasEnded == false) {
            Debug.Log(";lfajsdfk");
            gameHasEnded = true;
            Invoke("Restart", 1f);
            
        }
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
