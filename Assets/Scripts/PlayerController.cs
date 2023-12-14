using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30.0f; // Movement speed of the player
    private Rigidbody rb; // Rigidbody of the player

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component of the player
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Haz que el jugador se mueva con las teclas WASD
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * speed * 2 * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * speed * 2 * Time.deltaTime);
        //}
        // Haz el mismo código pero no con Translate sino con Velocity
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.velocity = Vector3.forward * speed * Time.deltaTime;
        //}
        //float moverHorizontal = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed * 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * speed * 2;
        }


        // Haz el jugador rote con las teclas Q y E
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * speed * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * speed * 5 * Time.deltaTime);
        }
    }
}
