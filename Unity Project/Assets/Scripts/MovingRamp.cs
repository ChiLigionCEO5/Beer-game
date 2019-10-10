using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRamp : MonoBehaviour
{
    public float moveSpeed = 1f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody;
    private float verrticalInput; 

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red; 
    }

    // Use fixed update for physics dode, because we need to be
    // careful about how often we call expensive, hardware intensive
    // physics stuff.

    private void FixedUpdate()
    {
        verrticalInput = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector2(0, verrticalInput* moveSpeed);
    }
}
