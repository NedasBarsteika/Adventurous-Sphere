using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat2 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            transform.position = teleportDestination.position;
        }
    }
}
