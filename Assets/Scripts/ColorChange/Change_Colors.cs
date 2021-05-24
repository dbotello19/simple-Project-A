using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Colors : MonoBehaviour
{
    Renderer Player;
    Color Red = new Color32(255,0,0,255);
    Color Blue = new Color32(0, 0, 255, 255);
    Color Yellow = new Color32(255, 255, 0, 255);
    Color LightGreen = new Color32(0, 255, 0, 255);
    Color Purple = new Color32(130, 0, 255, 255);
    Color Orange = new Color32(255, 165, 0, 255);
    Color HotPink = new Color32(255, 105, 180, 255);
    Color Cyan = new Color32(0, 255, 255, 255);
    Color Black = new Color32(0, 0, 0, 255);
    Color DarkGreen = new Color32(34, 188, 34, 1);
    Color LightPink = new Color32(255, 219, 233, 1);
    Color Brown = new Color32(225, 156, 63, 255);

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
    }
    public void RedColor()
    {
        Player.material.color = Red;
    }
    public void BlueColor()
    {
        Player.material.color = Blue;
    }
    public void YellowColor()
    {
        Player.material.color = Yellow;
    }
    public void LightGreenColor()
    {
        Player.material.color = LightGreen;
    }
    public void PurpleColor()
    {
        Player.material.color = Purple;
    }
    public void OrangeColor()
    {
        Player.material.color = Orange;
    }
    public void HotPinkColor()
    {
        Player.material.color = HotPink;
    }
    public void CyanColor()
    {
        Player.material.color = Cyan;
    }
    public void BlackColor()
    {
        Player.material.color = Black;
    }
    public void DarkGreenColor()
    {
        Player.material.color = DarkGreen;
    }
    public void LightPinkColor()
    {
        Player.material.color = LightPink;
    }
    public void BrownColor()
    {
        Player.material.color = Brown;
    }

}
