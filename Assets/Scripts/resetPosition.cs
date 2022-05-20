using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPosition : MonoBehaviour
{

    public Rigidbody rb;


    private void FixedUpdate()
    {
        if (rb.position.y < -8)
        {
            ResetPlayerPostion();
        }
    }
    void ResetPlayerPostion()
    {

        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(7f, -0.08f, 6.5f);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = true;
    }
}
