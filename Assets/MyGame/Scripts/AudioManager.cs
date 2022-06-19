using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Über die statische Referenz kann von jedem anderen Script ein Sound abgespielt werden

    public static AudioManager instance;

    public AudioSource ambience;
    public AudioSource kuekenIdle; 
    public AudioSource correctSound;
    public AudioSource wrongSound;

    void Awake()
    {
        // Zuweisung der Instanz

        instance = this;
    }

    void Start()
    {
        // Ambience Sounds sollen von Anfang an spielen

        ambience.Play();
        kuekenIdle.Play();
    }

    // Mit der PlaySound Methode kann von überall ein Sound abgespielt werden

    public void PlaySound(AudioSource audioSource)
    {
        audioSource.Play();
    }
}
