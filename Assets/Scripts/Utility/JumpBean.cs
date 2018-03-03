using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBean : MonoBehaviour {

    public Rigidbody rb;
    bool isGrounded;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        isGrounded = false;
    }

    void FixedUpdate ()
    {
        if (Random.value < .03 && isGrounded)
        {
            Vector3 randomDirection = new Vector3(Random.value * 60f - 30f, 0, Random.value*60f - 30f);
            rb.AddForce(Vector3.up * Random.value*120f + Vector3.up*50f +  randomDirection);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
