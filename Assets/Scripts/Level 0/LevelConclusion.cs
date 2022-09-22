using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelConclusion : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            bool conditionNextLevel;

            conditionNextLevel = GameObject.Find("BridgeTrigger").GetComponent<AutomaticBridgeController>().requirementMet;

            if(conditionNextLevel)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    }
}
