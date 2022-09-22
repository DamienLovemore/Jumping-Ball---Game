using UnityEngine;

public class GetCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("BridgeTrigger").GetComponent<AutomaticBridgeController>().requirementMet=true;
            Destroy(GameObject.Find("Coin"));
            Destroy(GameObject.Find("InvisibleBorder"));
            Destroy(GameObject.Find("InvisibleBorder (1)"));
            Destroy(GameObject.Find("InvisibleBorder (2)"));
            Destroy(GameObject.Find("InvisibleBorder (3)"));
        }
    }
}
