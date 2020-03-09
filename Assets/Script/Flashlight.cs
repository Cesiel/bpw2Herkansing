using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Vector3 mousePosition;
    public float speed;
    public GameObject light;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, speed);

        if (Input.GetKeyDown(KeyCode.F))
        {
            light.SetActive(!light.activeInHierarchy);
        }
    }
}
