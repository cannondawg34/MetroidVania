using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float j = 5;
    bool grounded = false;
    private Rigidbody2D body;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //get input and then applies it to rb 
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);



        if (Input.GetKeyDown(KeyCode.J)) //&& notGrounded
        {
            Jump();
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Jump()
    {
        //anim SetANIM
        body.velocity = new Vector2(body.velocity.x, j);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;

        }
    }
}
