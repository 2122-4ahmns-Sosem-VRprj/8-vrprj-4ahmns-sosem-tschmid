using UnityEngine;

public class Farbe : MonoBehaviour
{
    // Über das Enum kann im Inspector die Farbe des jeweiligen Farbeimers ausgewählt werden

    public enum MyEnum
    {
        Rot,
        Blau,
        Gruen
    }; 

    public MyEnum farbe;

    void Update()
    {
        switch (farbe.ToString())
        {
            case "Rot":
                GetComponent<Renderer>().material.color = Color.red;
                break;
            case "Blau":
                GetComponent<Renderer>().material.color = Color.blue;
                break;
            case "Gruen":
                GetComponent<Renderer>().material.color = Color.green;
                break;
        }
    }
}
