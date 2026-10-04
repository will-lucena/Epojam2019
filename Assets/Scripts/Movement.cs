using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]


public class Movement : MonoBehaviour
{
    [SerializeField] private string horizontalInput;
    [SerializeField] private string verticalInput;
    [SerializeField] private float movementVelocity;

    private float horizontalValue;
    private float verticalValue;   
    
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
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
            rb.linearVelocity = new Vector2(horizontalValue * movementVelocity, rb.linearVelocity.y);
        }
        else
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        //movimento vertical
        if (verticalValue != 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, verticalValue * movementVelocity);
        }
        else
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        }
    }

    private void LateUpdate()
    {
        animator.SetFloat("horizontalMove", rb.linearVelocity.x);
        animator.SetFloat("verticalMove", rb.linearVelocity.y);
    }
}
