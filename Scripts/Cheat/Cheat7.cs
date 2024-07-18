using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat7 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            transform.position = teleportDestination.position;
        }
    }
}