using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f; // Movement speed of the player

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input
        float verticalInput = Input.GetAxis("Vertical"); // Get the vertical input

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput); // Create a vector3 for the movement

        GetComponent<Rigidbody>().velocity = movement * speed; // Set the velocity of the player
    }
}
