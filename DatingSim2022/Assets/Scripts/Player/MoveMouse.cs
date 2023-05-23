using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMouse : MonoBehaviour
{
    private Vector3 mousePos, lookPos;
    private float angle;

    private void Update()
    {
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.z, 10);
        lookPos = Camera.main.ScreenToWorldPoint(mousePos);

        lookPos -= transform.position;
        angle = Mathf.Atan2(lookPos.z, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.down); // turns right
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up); // turns left
    }
}
