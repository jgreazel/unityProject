using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float speed = 15;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //float speedModifier = 1;
        //if (Input.GetButton("Fire1")) speedModifier = 1.8f;

        //var horizontalInput = Input.GetAxis("Horizontal");
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed * speedModifier);

        //var verticalInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed * speedModifier);
    }

    // movement is a little wack and player is able to force walk through walls...
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        playerRb.position += z * transform.forward * Time.deltaTime * speed;
        playerRb.position += x * transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Border"))
        {
            Debug.Log("HIT A WALL");
            playerRb.velocity = Vector3.zero;
        }
    }

    private void LateUpdate()
    {
        if(playerRb.velocity.x == 0)
        {

        }
    }
}
