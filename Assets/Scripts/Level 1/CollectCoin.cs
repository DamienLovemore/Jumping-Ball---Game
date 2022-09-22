using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform platformPlaced;
    public GameObject thisCoin;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Vector3 objectScale;

            spawnPoint.position =thisCoin.GetComponent<Transform>().position;

            objectScale = spawnPoint.lossyScale;
            spawnPoint.SetParent(platformPlaced);
            spawnPoint.localScale = objectScale;

            Destroy(thisCoin);
        }
    }
}
