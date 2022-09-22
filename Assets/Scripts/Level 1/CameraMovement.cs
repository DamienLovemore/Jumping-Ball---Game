using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 offSet;
    public GameObject player;
    
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.GetComponent<Transform>().position + offSet;
        transform.LookAt(player.GetComponent<Transform>());
    }
}
