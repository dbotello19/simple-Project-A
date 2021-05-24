using System.Collections;
using TMPro;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private Rigidbody rb;
    private Transform Camera;
    private GameObject Player;

    // Player Movement
    float thrust = 150f;
    //float speed = 20f;
    Vector3 fowardforce;
    Vector3 sideforce;
    Vector3 Jump;

    void OnEnable()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        Camera = GetComponent<Transform>();
        rb = Player.GetComponent<Rigidbody>();
        Jump = new Vector3(0, 30, 0);
    }


    void FixedUpdate()
    { 
        
        //READING FORCES
        fowardforce = Camera.forward;
        sideforce = Camera.right;
        



        PlayerMovement();

        //JUMP 

            if (Player.GetComponent<Player>().Onground)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    Player.GetComponent<Player>().Onground = false;
                    rb.AddForce(Jump * thrust);
                }
            }
       
        

    }

    void PlayerMovement()
    {
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

