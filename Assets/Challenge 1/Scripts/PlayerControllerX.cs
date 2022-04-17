using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private GameObject plane;
    private GameObject fan;

    private float speed = 20.0f;
    private float rotationSpeed = 90.0f;
    private float fanSpeed = 2000.0f;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Plane");
        fan = GameObject.Find("Fan");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1, 0, 0);
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // rotate fan
        fan.transform.Rotate(Vector3.forward, Time.deltaTime * fanSpeed);

        // move the plane forward at a constant rate
        plane.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        plane.transform.Rotate(Vector3.right, Time.deltaTime * rotationSpeed * horizontalInput);
        
    }
}
