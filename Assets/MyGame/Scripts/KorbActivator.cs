using UnityEngine;

public class KorbActivator : MonoBehaviour
{
    public GameObject korbParent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            // Korb soll erst gefunden werden können, wenn die Farben entdeckt wurden

            korbParent.SetActive(true);
        }
    }
}
