using UnityEngine;

public class BackgroundGameFunctions : MonoBehaviour
{
    private bool switchFullscreen;

    private void Start()
    {
        switchFullscreen = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            if(switchFullscreen)
            {
                Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
                switchFullscreen = false;
            }

            else
            {
                Screen.SetResolution(840, 647, false);
                switchFullscreen = true;
            }
        }
    }
}
