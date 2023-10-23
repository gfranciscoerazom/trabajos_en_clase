using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Movement speed of the airplane
    private Rigidbody rb;
    public GameObject bulletPrefab; // Prefab of the bullet
    public Transform cannonTransform; // Transform of the cannon

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        // Get keyboard input
        float horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input
        float verticalInput = Input.GetAxis("Vertical"); // Get the vertical input

        // Calculate the movement direction
        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput); // Create a vector3 for the movement

        // Apply force to move the object
        rb.velocity = movement * moveSpeed; // Set the velocity of the player

        if (Input.GetKeyDown(KeyCode.Space)) // Check if the space key is pressed
        {
            Instantiate(bulletPrefab, cannonTransform.position, Quaternion.identity); // Create a bullet
        }
    }
}
