using UnityEngine;

[System.Serializable]
public class UserData
{
    public float[] Color;
    public int SP;

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


   
    public UserData(Player player)
    {
        //USER'S PLAYER COLOR DATA
        Color = new float[3];
        Color[0] = player.GetComponent<Renderer>().material.color.r;
        Color[1] = player.GetComponent<Renderer>().material.color.g;
        Color[2] = player.GetComponent<Renderer>().material.color.b;

        //USER'S SKILL POINTS
        SP = player.SPs;

        //USER'S COMPLETED LEVELS
        Level01Completed = player.Level01Completed;
        Level02Completed = player.Level02Completed;
        Level03Completed = player.Level03Completed;
        Level04Completed = player.Level04Completed;
        Level05Completed = player.Level05Completed;
        Level06Completed = player.Level06Completed;
        Level07Completed = player.Level07Completed;
        Level08Completed = player.Level08Completed;
        Level09Completed = player.Level09Completed;
        Level10Completed = player.Level10Completed;
        Level11Completed = player.Level11Completed;
        Level12Completed = player.Level12Completed;
        Level13Completed = player.Level13Completed;
        Level14Completed = player.Level14Completed;
        Level15Completed = player.Level15Completed;
        Level16Completed = player.Level16Completed;
        Level17Completed = player.Level17Completed;
        Level18Completed = player.Level18Completed;


      
    }
}
