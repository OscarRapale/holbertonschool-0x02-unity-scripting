using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Public variable to control speed, adjustable in the Inspector
    public float speed = 5f;

    // Rigidbody component reference
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the Player
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input from the horizontal (A/D or Left/Right) and vertical (W/S or Up/Down) axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector on the X and Z axes
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force to the Rigidbody to move the Player
        rb.AddForce(movement * speed);
    }
}
