using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed = 15;
    public float jumpSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        var verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // jump is really more of a dash
        if (Input.GetButtonDown("Jump"))
        {
            var newPos = new Vector3(transform.position.x + horizontalInput * jumpSpeed, transform.position.y, transform.position.z + verticalInput * jumpSpeed);
            transform.position = Vector3.Lerp(transform.position, newPos, Time.deltaTime * 50);
        }
    }
}
