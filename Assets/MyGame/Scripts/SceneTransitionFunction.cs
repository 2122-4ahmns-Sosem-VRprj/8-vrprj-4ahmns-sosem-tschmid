using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionFunction : MonoBehaviour
{
    // Methode wird in der Animation gecalled

    public void TransitionScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
