using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour // using rotating Circle prefab
{

    public float speed;
    void Update()
    {
        transform.Rotate(0, 0, speed * Time.deltaTime); // moving around self
    }
}
