using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{

    public void SetInActivePlayerGravity()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = new Vector3(-27.49f, 2.35f, 26.57f);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>().useGravity = false;    
    }
}
