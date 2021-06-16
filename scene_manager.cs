using UnityEngine;
using UnityEngine.SceneManagement;
public class scene_manager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
    public void GameOver()
    {
         SceneManager.LoadScene(0);
    }
}
