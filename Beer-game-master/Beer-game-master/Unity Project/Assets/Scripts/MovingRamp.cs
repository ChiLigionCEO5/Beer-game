using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRamp : MonoBehaviour
{
    public float moveSpeed = 1f;

    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rigidbody;
    private float verrticalInput;
    public string inputAxis;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
        
    }
    private void Update()
    {
        verrticalInput = Input.GetAxis(inputAxis);
    }
    // Use fixed update for physics dode, because we need to be
    // careful about how often we call expensive, hardware intensive
    // physics stuff.

    private void FixedUpdate()
    {
        
        rigidbody.velocity = new Vector2(0, verrticalInput* moveSpeed);
    }
}
