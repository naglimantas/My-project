using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDancer : MonoBehaviour
{
    public float sensitivity = 10f;

    public void Dance(float volume)
    {
        transform.position = Vector3.back * volume * sensitivity;
    }
}
