using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat6 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            transform.position = teleportDestination.position;
        }
    }
}