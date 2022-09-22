using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
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
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);

        if((Input.GetButtonDown("Jump")) && (isGrounded))
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            isGrounded = false;
        }

        if(transform.position.y<=-1.5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
