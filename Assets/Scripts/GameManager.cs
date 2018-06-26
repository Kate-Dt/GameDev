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

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

	public void OpenMenu() {
		Time.timeScale = 1f;
		SceneManager.LoadScene("StartMenu");
	}
}
