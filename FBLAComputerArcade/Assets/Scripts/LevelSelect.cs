using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelect : MonoBehaviour
{
    void Update() {
        if(Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }
    }
    
    // Load the chosen level
    public void PlayLevel(int level) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
}
