using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class UpdateUi : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject victoryPanel;
    public GameObject pausePanel;
    public TMP_Text scoreText;
    public int score;
    public FinalDoor finaldoor;
    bool OpenDoors = false;
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (score >= 1 && !OpenDoors)
        {
            OpenDoors = true;
            finaldoor.OpenFinalDoors();
        }

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            PauseMenu();
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseMenu()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }
    
    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Points: " + score.ToString();
    }
    public void VictoryPanel()
    {
        Time.timeScale = 0;
        victoryPanel.SetActive(true);
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

}
