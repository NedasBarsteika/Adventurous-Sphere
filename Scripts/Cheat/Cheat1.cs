using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheat1 : MonoBehaviour
{
    public Transform teleportDestination;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            transform.position = teleportDestination.position;
        }
    }
}