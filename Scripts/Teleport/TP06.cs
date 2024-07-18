using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP06 : MonoBehaviour
{
    public Transform teleportDestination;
    void OnTriggerEnter(Collider _c)
    {
        if (_c.gameObject.tag == "teleport06")
        {
            transform.position = teleportDestination.position;
        }
    }

}