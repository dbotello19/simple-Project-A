using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [HideInInspector]
    public bool Onground;
    [HideInInspector]
    public bool Contact;

    public bool JumpOnce;
    public bool Q_DropDownActive;
    public bool E_DropDownActive;
    public bool R_DropDownActive;
    public static Player instance;
    public int SPs = 0;

    //USER'S LEVELS COMPLETED
    public bool Level01Completed;
    public bool Level02Completed;
    public bool Level03Completed;
    public bool Level04Completed;
    public bool Level05Completed;
    public bool Level06Completed;
    public bool Level07Completed;
    public bool Level08Completed;
    public bool Level09Completed;
    public bool Level10Completed;
    public bool Level11Completed;
    public bool Level12Completed;
    public bool Level13Completed;
    public bool Level14Completed;
    public bool Level15Completed;
    public bool Level16Completed;
    public bool Level17Completed;
    public bool Level18Completed;






    private void Awake()
    {
        LoadPlayer();

        DontDestroyOnLoad(gameObject);
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Map")
        {
            JumpOnce = true;
            Onground = true;
        }
        if(collision.gameObject.tag == "Obstacle")
        {
            Contact = true;
        }
 
    }

    public void SavePlayer()
    {
        SaveSystem.SaveUser(this);
    }    

    public void LoadPlayer()
    {
        UserData data = SaveSystem.LoadUser();

        bool Level01_Complete = data.Level01Completed;
        bool Level02_Complete = data.Level02Completed;
        bool Level03_Complete = data.Level03Completed;
        bool Level04_Complete = data.Level04Completed;
        bool Level05_Complete = data.Level05Completed;
        bool Level06_Complete = data.Level06Completed;
        bool Level07_Complete = data.Level07Completed;
        bool Level08_Complete = data.Level08Completed;
        bool Level09_Complete = data.Level09Completed;
        bool Level10_Complete = data.Level10Completed;
        bool Level11_Complete = data.Level11Completed;
        bool Level12_Complete = data.Level12Completed;
        bool Level13_Complete = data.Level13Completed;
        bool Level14_Complete = data.Level14Completed;
        bool Level15_Complete = data.Level15Completed;
        bool Level16_Complete = data.Level16Completed;
        bool Level17_Complete = data.Level17Completed;
        bool Level18_Complete = data.Level18Completed;


        Vector3 color;
        color.x = data.Color[0];
        color.y = data.Color[1];
        color.z = data.Color[2];
        GetComponent<Renderer>().material.color = new Color(color.x,color.y,color.z);
        SPs = data.SP;

        Level01Completed = Level01_Complete;
        Level02Completed = Level02_Complete;
        Level03Completed = Level03_Complete;
        Level04Completed = Level04_Complete;
        Level05Completed = Level05_Complete;
        Level06Completed = Level06_Complete;
        Level07Completed = Level07_Complete;
        Level08Completed = Level08_Complete;
        Level09Completed = Level09_Complete;
        Level10Completed = Level10_Complete;
        Level11Completed = Level11_Complete;
        Level12Completed = Level12_Complete;
        Level13Completed = Level13_Complete;
        Level14Completed = Level14_Complete;
        Level15Completed = Level15_Complete;
        Level16Completed = Level16_Complete;
        Level17Completed = Level17_Complete;
        Level18Completed = Level18_Complete;


    }
}
