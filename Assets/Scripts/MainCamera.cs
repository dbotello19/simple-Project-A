using UnityEngine;
//using UnityEngine.Experimental.UIElements;

public class MainCamera : MonoBehaviour
{
    Transform player;
    public Vector3 offset;

    float turnSpeed = 20f;


    private void Start()
    {        
        Cursor.visible = false;
        player = GameObject.Find("Player").GetComponent<Transform>();
        offset = new Vector3(player.position.x + 19f, player.position.y + 1f, player.position.z + -12.5f);
       
    }
    void LateUpdate()
    {

        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime, new Vector3(1, 0, 1)) * offset ;
        if (offset.y > 10 || offset.y < 0)
        {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime, new Vector3(-1,0,-1)) * offset;
        }

        

       offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime, Vector3.up) * offset;

       





        transform.position = player.position + offset;

        //Debug.Log(offset.z);
        transform.LookAt(player.position);

    }

}
