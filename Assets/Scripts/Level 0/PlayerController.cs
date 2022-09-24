using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Transform rayStart; 

    public float speed;
    
    private Rigidbody rb;
    
    public float jumpStrength;
     

    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;

        GameObject.Find("InvisibleBorder").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("InvisibleBorder (1)").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("InvisibleBorder (2)").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("InvisibleBorder (3)").GetComponent<MeshRenderer>().enabled = false;
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
