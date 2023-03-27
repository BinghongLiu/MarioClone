using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class PlatformerPlayer : MonoBehaviour
{
    public float speed = 3.5f;

    private Rigidbody2D body;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        Vector2 movement = new Vector2(deltaX, body.velocity.y);
        body.velocity = movement;
    }

  
}
