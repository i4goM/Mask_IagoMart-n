using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateObject : MonoBehaviour
{
    [SerializeField] int speed = 50;

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    public void sumarVelocidad ()
    {
        speed = speed + 10;
    }

    public void restarVelocidad()
    {
        speed = Mathf.Max(0, speed - 10);
    }
}
