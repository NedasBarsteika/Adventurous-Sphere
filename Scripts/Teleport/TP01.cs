using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP01 : MonoBehaviour
{
    public Transform teleportDestination;
    void OnTriggerEnter(Collider _c)
    {
        if (_c.gameObject.tag == "teleport01")
        {
            transform.position = teleportDestination.position;
        }
    }
}
