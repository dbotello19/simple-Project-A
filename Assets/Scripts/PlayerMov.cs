using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Rigidbody rb;
    private Transform Camera;
    private GameObject Player;

    // Player Movement
    float thrust = 20f;
    Vector3 fowardforce;
    Vector3 sideforce;
    Vector3 bounce;

    void OnEnable()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        Camera = GetComponent<Transform>();
        rb = Player.GetComponent<Rigidbody>();
        bounce = new Vector3(0, 30, 0);
    }


    void FixedUpdate()
    { 
        
        //READING FORCES
        fowardforce = Camera.forward;
        sideforce = Camera.right;
        



        PlayerMovement();
        
        //bounce
        if (Player.GetComponent<Player>().Onground)
        {
            var normalBounce = bounce.normalized;
            Player.GetComponent<Player>().Onground = false;
                rb.AddForce(bounce * thrust);
                
        }
       
        

    }

    void PlayerMovement()
    {
        var normalSideforce = sideforce.normalized;
        var normalFowardforce = fowardforce.normalized;

        //FOWARD
            Player.transform.rotation = Quaternion.Euler(Player.transform.rotation.x, Player.transform.rotation.y, Player.transform.rotation.z);
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.AddForce(fowardforce * thrust);

            }
            //LEFT
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-sideforce * thrust);

            }
            //RIGHT
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(sideforce * thrust);

            }
            //BACKWARD
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                rb.AddForce(-fowardforce * thrust);

            } 
    }

}

