using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Colors : MonoBehaviour
{
    Renderer rendPlayer;
    GameObject Player;

    Color Red = new Color32(255,0,0,255);
    Color Blue = new Color32(0, 0, 255, 255);
    Color Yellow = new Color32(255, 255, 0, 255);
    Color LightGreen = new Color32(0, 255, 0, 255);
    Color Purple = new Color32(130, 0, 255, 255);
    Color Orange = new Color32(255, 165, 0, 255);
    Color HotPink = new Color32(255, 105, 180, 255);
    Color Cyan = new Color32(0, 255, 255, 255);
    Color Black = new Color32(106, 106, 106, 255);
    Color DarkGreen = new Color32(34, 188, 34, 1);
    Color LightPink = new Color32(255, 219, 233, 1);
    Color Brown = new Color32(58, 38, 12, 255);

    private void Start()
    {        
        Player = GameObject.FindGameObjectWithTag("Player");

        rendPlayer = Player.GetComponent<Renderer>();
    }
    public void RedColor()
    {
        rendPlayer.material.color = Red;        
    }
    public void BlueColor()
    {
        rendPlayer.material.color = Blue;
    }
    public void YellowColor()
    {
        rendPlayer.material.color = Yellow;
    }
    public void LightGreenColor()
    {
        rendPlayer.material.color = LightGreen;
    }
    public void PurpleColor()
    {
        rendPlayer.material.color = Purple;
    }
    public void OrangeColor()
    {
        rendPlayer.material.color = Orange;
    }
    public void HotPinkColor()
    {
        rendPlayer.material.color = HotPink;
    }
    public void CyanColor()
    {
        rendPlayer.material.color = Cyan;
    }
    public void BlackColor()
    {
        rendPlayer.material.color = Black;
    }
    public void DarkGreenColor()
    {
        rendPlayer.material.color = DarkGreen;
    }
    public void LightPinkColor()
    {
        rendPlayer.material.color = LightPink;
    }
    public void BrownColor()
    {
        rendPlayer.material.color = Brown;
    }

}
