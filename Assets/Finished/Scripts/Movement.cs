using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{

    private Vector3 moveAmount;  //(x,y,z)
    private Rigidbody2D rb;
    [SerializeField] private float speed;


    // Start is called before the first frame update
    void Start()
    {
        moveAmount = Vector3.zero;
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveAmount = Vector3.zero;
        float vInput = Input.GetAxisRaw("Vertical");
        float hInput = Input.GetAxisRaw("Horizontal");
        moveAmount = new Vector3(hInput, vInput, 0);
        moveAmount.Normalize();
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        rb.velocity = moveAmount * speed;
    }
}
