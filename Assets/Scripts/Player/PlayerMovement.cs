using UnityEngine;



// Personal note, if Unity C# scripts don't have any autocompletion, go to External Tools to enable Visual Studio Community



public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 10f;
    //public float sidewaysForce = 500f;
    public float jumpForce = 600f;
    public static bool isOnTheGround = true;


    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        // Adds a forward force, default 10 constantly so the cube is always moving forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        // If horizontal keys are pressed -> does the code below
        if (Input.GetButton("Horizontal"))
        {
            rb.AddForce(Input.GetAxis("Horizontal") * sidewaysForce, 0, 0);
        }
        */

        // Retrieves controls keys from the Edit -> Project Settings -> Input Manager -> Horizontal 
        // GetAxis("Horizontal") gets if it's a positive (right) or negative (left) force 
        // GetAxis("Vertical") gets if it's a positive (up) or negative (down) force 
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * forwardForce;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * forwardForce;
        transform.Translate(horizontal, 0, vertical);

        if (Input.GetButton("Jump") && isOnTheGround == true)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            isOnTheGround = false;
        }

    }

}
