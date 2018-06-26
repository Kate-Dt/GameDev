using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

	public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", restartDelay);
        }

    }
	public void LoadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	public void OpenMenu() {
		SceneManager.LoadScene("StartMenu");
		Time.timeScale = 1f;
	}
}
