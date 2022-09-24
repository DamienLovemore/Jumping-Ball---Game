using UnityEngine;

public class BackgroundFunctions : MonoBehaviour
{
    void Start()
    {
        GameObject exitButtonText = GameObject.Find("ExitText");
        exitButtonText.GetComponent<TMPro.TextMeshProUGUI>().text = "Exit";
    }
       
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F11))
        {
            FullScreenMode actualScreenMode = Screen.fullScreenMode;

            if ((actualScreenMode == FullScreenMode.Windowed) || (actualScreenMode == FullScreenMode.MaximizedWindow))
            {
                Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            }
            else
            {
                Screen.fullScreenMode = FullScreenMode.Windowed;
            }
        }
    }
}
