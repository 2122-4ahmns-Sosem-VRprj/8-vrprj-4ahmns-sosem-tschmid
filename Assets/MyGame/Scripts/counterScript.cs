using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counterScript : MonoBehaviour
{
    public static int count = 0;
    public GameObject wall1;

    private void Update()
    {

        Debug.Log(count);
        if(count == 4)
        {
            wall1.GetComponent<Renderer>().material.color = Color.green;
        }

        else
        {

        }
    }


}
