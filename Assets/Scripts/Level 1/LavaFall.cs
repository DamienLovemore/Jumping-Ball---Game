using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaFall : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPoint;
    public GameObject placeHolder;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag==player.tag)
        {
            player.GetComponent<Transform>().position = spawnPoint.GetComponent<Transform>().position;                        
        }
    }
}
