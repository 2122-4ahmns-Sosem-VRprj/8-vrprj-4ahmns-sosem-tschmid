using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorScript : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Bucket":
                transform.GetComponent<Renderer>().material.color = other.gameObject.GetComponent<Renderer>().material.color;
                break;
            case "SnappingArea":
                if(gameObject.GetComponent<Renderer>().material.color == other.gameObject.GetComponent<Renderer>().material.color)
                {
                    other.gameObject.GetComponent<AudioSource>().Play();
                    gameObject.GetComponent<XRGrabInteractable>().enabled = false;
                    gameObject.transform.position = other.gameObject.transform.position;
                    gameObject.transform.rotation = other.gameObject.transform.rotation;
                    gameObject.GetComponent<Rigidbody>().useGravity = false;
                    gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                    other.gameObject.GetComponent<SphereCollider>().enabled = false;
                    counterScript.count++;

                }
                break;
        }
    }
}