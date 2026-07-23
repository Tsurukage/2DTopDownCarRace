using System;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private float horizontal;
    private float vertical;

    [SerializeField]private float runSpeed;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        body.linearVelocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
