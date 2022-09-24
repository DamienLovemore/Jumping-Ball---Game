using UnityEngine;

public class MovePlayerAlong : MonoBehaviour
{
    private GameObject placeHolder;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag=="Player")
        {
            placeHolder = new GameObject("Placeholder - Avoid Resizing");
            placeHolder.transform.parent = transform;
            GameObject.Find("Player").transform.parent = placeHolder.transform;            
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.gameObject.tag=="Player")
        {
            GameObject.Find("Player").transform.SetParent(null);
            Destroy(placeHolder);
        }
    }
}
