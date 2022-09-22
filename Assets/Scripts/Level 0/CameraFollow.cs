using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
       
    public Vector3 offSet;

    private void LateUpdate()
    {
        transform.position = player.position+offSet;
        transform.LookAt(player);
    }
}
