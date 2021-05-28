using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    public float turnSpeed = 1.0f;

    private void Start()
    {
        Cursor.visible = false;
        offset = new Vector3(player.position.x + 10.0f, player.position.y + 1.0f, player.position.z + -30.0f);
    }


    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);

    }

}
