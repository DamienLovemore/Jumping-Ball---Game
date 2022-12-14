using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool isGamePaused = false;

    private bool showingControls = false;

    public GameObject pauseMenu;

    public GameObject controlImage;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused == false)
            {
                pauseGame();
            }

            else
            {
                resumeGame();
            }
        }

        else if (Input.GetKeyDown(KeyCode.F11))
        {
            FullScreenMode actualScreenMode = Screen.fullScreenMode;

            if((actualScreenMode == FullScreenMode.Windowed) || (actualScreenMode == FullScreenMode.MaximizedWindow))
            {
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            }
            else
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
        }
    }

    void pauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }

    public void resumeButtonAction()
    {
        GameObject resumeButtonText = GameObject.Find("ResumeText");

        if (resumeButtonText.GetComponent<TMPro.TextMeshProUGUI>().text == "RESUME")
        {
            resumeGame();
        }

        else
        {
            showGameControls();
        }
    }

    public void saveGameLevel()
    {
        PlayerPrefs.SetInt("Actual level", SceneManager.GetActiveScene().buildIndex);
        resumeButtonAction();
    }

    public void showGameControls()
    {
        print("Coisa");
        GameObject resumeButtonText = GameObject.Find("ResumeText");

        if (showingControls == false)
        {
            controlImage.SetActive(true);
            resumeButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "Return";
            showingControls = true;
        }

        else
        {
            controlImage.SetActive(false);
            resumeButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "RESUME";
            showingControls = false;
        }
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
