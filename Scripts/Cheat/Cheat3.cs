using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat3 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            transform.position = teleportDestination.position;
        }
    }
}