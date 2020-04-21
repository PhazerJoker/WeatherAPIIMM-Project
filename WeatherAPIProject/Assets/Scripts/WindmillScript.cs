using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindmillScript : MonoBehaviour
{
    public GameObject pinWheel;
    public void WindmillSpeed(int condition)
    {
        pinWheel.transform.Rotate(condition, 0.0f, 0.0f, Space.Self); //Rotates along x axis based on value of condition, rotation on y and z is null. Space.Self says its rotateing in comparison to itself
    }
}

