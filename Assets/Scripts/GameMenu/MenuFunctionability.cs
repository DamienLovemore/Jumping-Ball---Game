using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFunctionability : MonoBehaviour
{
    private bool showingCredits=false;
    public GameObject creditsImage;

    public void startNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void continueSavedGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Actual level"));
    }

    public void showCreditsGame()
    {
        GameObject exitButtonText = GameObject.Find("ExitText");

        if (showingCredits==false)
        {
            creditsImage.SetActive(true);
            exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "Return";
            showingCredits = true;
        }

        else
        {
            creditsImage.SetActive(false);
            exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "Exit";
            showingCredits = false;
        }
    }

    public void exitGame()
    {
        GameObject exitButtonText=GameObject.Find("ExitText");
        
        if (exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text=="Exit")
        {
            Application.Quit();
        }

        else if (exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text == "Return")
        {
            showCreditsGame();
        }
    }
}
