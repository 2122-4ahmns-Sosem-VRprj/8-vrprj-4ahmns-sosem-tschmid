using UnityEngine;
 
public class Ausgang : MonoBehaviour
{
    public Animator animator;

    public void OpenAusgang()
    {
            animator.SetBool("OpenAusgang", true);
    }
}
