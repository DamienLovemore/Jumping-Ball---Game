using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public GameObject spawnPoint;

    public Transform rayStart;

    public float speed;

    private Rigidbody rb;

    public float jumpStrength;


    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }
        
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
        float moveVertical = Input.GetAxisRaw("Vertical") * speed;
        moveHorizontal *= Time.deltaTime;
        moveVertical *= Time.deltaTime;

        transform.Translate(moveHorizontal, 0, moveVertical, Space.World);

        if ((Input.GetKey(KeyCode.Space)) && (isGrounded))
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void Update()
    {
        if ((Physics.Raycast(rayStart.position, -transform.up, Mathf.Infinity) == false) && (transform.position.y <= -1.5))
        {
            player.GetComponent<Transform>().position = spawnPoint.GetComponent<Transform>().position;
        }
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
