using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour
{
    
    public GameObject laser;
    void Start()
    {
        StartCoroutine(ShowAndHide(3.0f));
    }
    IEnumerator ShowAndHide(float delay)
    {
        laser.SetActive(true);
        yield return new WaitForSeconds(delay);
        laser.SetActive(false);
    }
}
