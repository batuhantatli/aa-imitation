using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour // using main Circle prefab
{
    public GameObject MiniCircle;
    GameObject callerController;

    void Start()
    {
        callerController = GameObject.FindGameObjectWithTag("Controller"); //called controller's script
    }

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
        callerController.GetComponent<Controller>().showerMiinCircleText();
    }
}
