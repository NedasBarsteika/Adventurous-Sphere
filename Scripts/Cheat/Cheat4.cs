using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat4 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            transform.position = teleportDestination.position;
        }
    }
}