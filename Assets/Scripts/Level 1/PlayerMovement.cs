using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed;
            
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
        
    void FixedUpdate()
    {
        float movementHorizontal;
        float movementVertical;
        Vector3 newDirection;

        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");

        newDirection = new Vector3(movementHorizontal, 0, movementVertical);

        rb.AddForce(newDirection * movementSpeed);
    }
}
