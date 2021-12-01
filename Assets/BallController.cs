 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public int moveSpeed;
    Rigidbody rb;
    bool onTheGround = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && onTheGround)
        {
            rb.AddForce(new Vector3(0, 10f, 0f), ForceMode.Impulse);
            onTheGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            onTheGround = true;
        }
    }
}
