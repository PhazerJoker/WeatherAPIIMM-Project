using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour
{
    public GameObject[] activateOnStart;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (GameObject go in activateOnStart)
        {
            go.SetActive(true);
        }
    }
}
