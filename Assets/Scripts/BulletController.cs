using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10.0f; // Speed of the bullet
    public float maxDistance = 100.0f; // Maximum distance the bullet can travel
    private Vector3 initialPosition; // Initial position of the bullet

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position; // Set the initial position of the bullet
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Move the bullet forward

        // Check if the bullet has traveled the maximum distance
        if (Vector3.Distance(initialPosition, transform.position) >= maxDistance)
        {
            Destroy(gameObject); // Destroy the bullet
        }
    }
}
