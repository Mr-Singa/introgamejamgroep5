using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dier : MonoBehaviour
{
    public float dierSPEED;

    void Start()
    {
        dierSPEED = 2f;
    }

    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * dierSPEED);
    }
}
