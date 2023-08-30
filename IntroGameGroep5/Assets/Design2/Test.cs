using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float SPEED;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.up * SPEED * Time.deltaTime);
    }
}
