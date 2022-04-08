using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedincreaser : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            var rb = other.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z * 40f);
            rb.AddForce(force);
        }
    }
}
