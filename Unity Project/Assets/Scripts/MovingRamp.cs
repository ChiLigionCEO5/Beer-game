using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRamp : MonoBehaviour
{
    private float moveSpeed = 0.1f; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
        // transform.Translate(5, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // If the player presses up arrow, we move the square up.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -moveSpeed, 0);
        }
    }
}
