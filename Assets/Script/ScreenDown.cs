using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDown : MonoBehaviour

{
    public float baseSpeed = 5f;
    public float speedMultiplier = 1f;
    [SerializeField]
    private float minCamSpeed = 1f;
    [SerializeField]
    private float maxCamSpeed = 10f;
    public float speedUp = 0f;
    public float speedDown = 0f;

    void Update()
    {


        //if (Input.GetKey("w"))
        // {
        //     pos.y += baseSpeed * Time.deltaTime;
        // }

        // if (Input.GetKey("s"))
        // {
        //     pos.y -= baseSpeed * Time.deltaTime;
        // }

        speedMultiplier = Mathf.Clamp(speedMultiplier, minCamSpeed, maxCamSpeed); // 10 is de maximum camera snelheid, pam zelf aan

        if (Input.GetAxis("Vertical") != 0)
        {
            speedMultiplier += Input.GetAxis("Vertical");
        }

        Vector3 pos = transform.position;
        pos.y += (baseSpeed *speedMultiplier) * Time.deltaTime;
        transform.position = pos;

    }
}
