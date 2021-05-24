using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Fade the color from red to green
    // back and forth over the defined duration

    Renderer rend;
    Renderer PlayerColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        PlayerColor = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            rend.material.SetColor("_Color", PlayerColor.material.GetColor("_Color"));
        }
    }

    public void ChangeColors()
    {
        rend.material.SetColor("_Color", PlayerColor.material.GetColor("_Color"));

    }
}