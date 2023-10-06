using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRBController : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 2;
    public float jumpAmount = 1;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.gameObject.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        
    }

    private void FixedUpdate()
    {

        // Movement ----------------------------------
        //Store user input as a movement vector

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 m_Input = new Vector3(x, 0, z);

        //Apply the movement vector to the current position, which is
        //multiplied by deltaTime and speed for a smooth MovePosition
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * 2);
        // Movement --------------------------------------


        // Jump -----------------------------
        Debug.Log(Input.GetAxis("Jump"));

        if(Input.GetAxis("Jump") != 0)
        {
            // Add Force ( Telling it magnitude and direction, how to impart force )
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
        }
        // Jump ----------------------------------------
    }


}
