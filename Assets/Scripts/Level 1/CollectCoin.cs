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
            spawnPoint.position = thisCoin.GetComponent<Transform>().position;
            spawnPoint.transform.parent = platformPlaced.transform;

            Destroy(thisCoin);
        }
    }
}
