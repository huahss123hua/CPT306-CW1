using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    public Vector2 velocity;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, -1 * speed);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        rb.position = new Vector3(Mathf.Clamp(rb.position.x, -4, 4), Mathf.Clamp(rb.position.y, -1, 3), 0);
    }




}
