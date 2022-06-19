using UnityEngine;

public class MinimapIndicator : MonoBehaviour
{
    public Transform minimapCamera;

    void Update()
    { 
        // Die Position des Indikators ist immer gleich der Spielerkamera

        gameObject.transform.position = new Vector3(minimapCamera.position.x,5, minimapCamera.position.z);
    }
}
