using UnityEngine;

public class MovePlayerAlong : MonoBehaviour
{
    private Vector3 originalScale;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag=="Player")
        {
            originalScale = GameObject.Find("Player").transform.lossyScale;
            GameObject.Find("Player").transform.SetParent(transform);
            GameObject.Find("Player").transform.localScale = originalScale;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.collider.gameObject.tag=="Player")
        {
            GameObject.Find("Player").transform.SetParent(null);
            GameObject.Find("Player").transform.localScale = originalScale;
        }
    }
}
