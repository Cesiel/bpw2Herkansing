using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D RB;
    Vector2 movement;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        RB.MovePosition(RB.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
