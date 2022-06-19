using UnityEngine;

public class SceneTransitionSetter : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("TransitionScene");
        }
    }
}