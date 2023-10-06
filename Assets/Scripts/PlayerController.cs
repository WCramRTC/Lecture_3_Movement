using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("THis ran on start");

        // Vector3 (x, y, z)
        // Vector3 (0,1,0);
        // What do i write if I want my cube to be -3 in x axis, 2 in the y, and 1 int z
  

    }

    public float speed = 2;

    // Update is called once per frame
    void Update()
    {
 
        // What is Input.GetAxis
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Hover");

        //Debug.Log($"x: {x} - z: {z}");

        Vector3 movement = new Vector3(x, y, z);
        transform.Translate(movement * speed * Time.deltaTime);
        // movement = Vector3(-1, 0, 1);

        // Vector3(-1, 0,1 ) * 2
        // Vector3(-2,0,2)
        //transform.Translate(movement * speed);

        // time.deltatime = .006

        // Vector3 (-1, 0, 1 ) * 2 * .0006
        // Vector3(-2,0,2) * .0006




        // Input.GetButtonDown


        //if(Input.GetButtonDown("Jump"))
        //{
        //    //Debug.Log("The key was pressed");
        //    this.transform.position = new Vector3(-3, 2, 1);
        //}





    }
}
