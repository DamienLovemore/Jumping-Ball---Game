using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpStrength;
    private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Jump")) && (isGrounded))
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isGrounded = false;
        }

        if (transform.position.y <= -1)
        {
            transform.position = GameObject.Find("SpawnPoint").GetComponent<Transform>().position;
        }
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
