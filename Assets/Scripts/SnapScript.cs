using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

public class SnapScript : MonoBehaviour
{
    public XRSocketInteractor socketInteractorScript;

    private void OnTriggerEnter(Collider other)
    {
        if (GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
        {
            socketInteractorScript.enabled = true;
        }
        else
        {
            socketInteractorScript.enabled = false;
        }
    }
}
