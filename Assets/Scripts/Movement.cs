using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class Movement : MonoBehaviour
{
    float horizontalValue;
    float verticalValue;
    public string horizontalInput;
    public string verticalInput;
    public float movementVelocity;
    Rigidbody2D rb;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalValue = Input.GetAxis(horizontalInput);
        verticalValue = Input.GetAxis(verticalInput);
    }

    private void FixedUpdate()
    {
        //movimento horizontal
        if (horizontalValue != 0)
        {
            rb.velocity = new Vector2(horizontalValue * movementVelocity, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        //movimento vertical
        if (verticalValue != 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, verticalValue * movementVelocity);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
    private void LateUpdate()
    {

    }
}
