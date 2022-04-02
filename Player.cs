using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour // using main Circle prefab
{
    public GameObject MiniCircle;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            miniCircleCreate();
        }
    }

    void miniCircleCreate() //creating miniCircle prefabs
    {
        Instantiate(MiniCircle, transform.position, transform.rotation);
    }
}
