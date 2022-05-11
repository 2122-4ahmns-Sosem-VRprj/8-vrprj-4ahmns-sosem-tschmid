using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{

    public Color redcolor;
    public Color bluecolor;


  void OntriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("RedPaddle"))
        {
            Debug.Log("It's ALIVE and red");
            transform.GetComponent<Renderer>().material.color = redcolor;
        }

        if (other.gameObject.CompareTag("BluePaddle"))
        {
            Debug.Log("It's ALIVE and blue");
            transform.GetComponent<Renderer>().material.color = bluecolor;
        }
    }


}