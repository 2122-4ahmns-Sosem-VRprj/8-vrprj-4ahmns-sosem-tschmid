using UnityEngine;

public class EiManager : MonoBehaviour
{
    public Material eiMaterial;
    public Color defaultColor;
     
    private void Start()
    {
        // Am Anfang wird dem Renderer die Default Farbe zugewiesen

        GetComponent<Renderer>().material.color = defaultColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Wenn das Ei mit einem Farbeimer kollidiert (Color Tag) soll das Ei die Farbe des Eimers annehmen

        if (other.gameObject.CompareTag("Color"))
        {
            switch (other.gameObject.GetComponent<Renderer>().material.color)
            {
                case var value when value == Color.red:
                    GetComponent<Renderer>().material.color = Color.red;
                    break;
                case var value when value == Color.blue:
                    GetComponent<Renderer>().material.color = Color.blue;
                    break;
                case var value when value == Color.green:
                    GetComponent<Renderer>().material.color = Color.green;
                    break;

            }
        }
    }
}
