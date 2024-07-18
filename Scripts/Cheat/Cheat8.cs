using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat8 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            transform.position = teleportDestination.position;
        }
    }
}