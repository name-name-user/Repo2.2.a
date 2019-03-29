using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float dirX, dirY;
    public float moveSpeed = 5f;
    Rigidbody2d rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2d> ();
    }

    
    void Update()
    {
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
    }

    void fixedUpdate()
    {
        rb.Velocity = new Vector2(dirX * moveSpeed);
    }
}
