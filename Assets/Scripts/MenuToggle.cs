using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuToggle : MonoBehaviour
{
    public GameObject menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            menu.SetActive(!menu.activeSelf);
        }
    }
}
