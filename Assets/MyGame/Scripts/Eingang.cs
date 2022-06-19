using UnityEngine;

public class Eingang : MonoBehaviour 
{
    public Animator animtor;

    private void OnTriggerEnter(Collider other)
    {
        // Sobald der Spieler das Maze betreten hat, gibt es kein Zurück mehr

        if (other.CompareTag("Player"))
        { 
            animtor.SetBool("CloseEingang", true);
        }
    }
}
