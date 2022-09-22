using UnityEngine;

public class BackgroundFunctions : MonoBehaviour
{
    private bool isFullscreen;

    void Start()
    {
        isFullscreen = false;
        GameObject exitButtonText = GameObject.Find("ExitText");
        exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "Exit";
    }
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F11))
        {
            if(isFullscreen==false)
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
                isFullscreen = true;
            }

            else
            {
                Screen.SetResolution(840, 607, false);
                isFullscreen = false;
            }
        }
    }
}
