using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;

        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = cursorPosition;
    }
}
