using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorScript : MonoBehaviour
{

  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bucket"))
        {
            transform.GetComponent<Renderer>().material.color = other.gameObject.GetComponent<Renderer>().material.color;

            GameObject[] x = GameObject.FindGameObjectsWithTag("SnappingArea");

            foreach(GameObject i in x)
            {
                i.GetComponent<XRSocketInteractor>().enabled = false;
            }
        }
    }
}