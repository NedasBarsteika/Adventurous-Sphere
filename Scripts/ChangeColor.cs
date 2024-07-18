using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material color1;
    public Material color2;

    void OnTriggerEnter(Collider other)
    {
        print(other.name);
        if (other.name == "Sphere")
        {
            // green on trigger
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Player Collided with CUBE");
        }
        else
        {
            //  red if trigger
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
   /* void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Sphere")
        {
            //Stay green after exit on trigger
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Player Exit");
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.red;

        }
    }
    */
}