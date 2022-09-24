using UnityEngine;

public class BackgroundGameFunctions : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
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
