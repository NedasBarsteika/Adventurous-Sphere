using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat5 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            transform.position = teleportDestination.position;
        }
    }
}