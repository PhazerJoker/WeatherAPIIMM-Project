using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] activateOnStart;
    // On Awake the gameobjects clear, cloudy, and rainy are set active.
    void Awake()
    {
        foreach (GameObject go in activateOnStart)
        {
            go.SetActive(true);
        }
    }
}
