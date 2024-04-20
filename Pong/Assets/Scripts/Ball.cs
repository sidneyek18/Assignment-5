using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Ball speed
    float speed = 5f;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Get rididbody of ball and add force to move it when game starts
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up * speed, ForceMode2D.Impulse);
    }

    //When the ball hits a wall send it in oppisite direction
    void OnCollisionEnter2D(Collision2D collision)
    {
        rigidbody.AddForce(transform.up * -speed, ForceMode2D.Impulse);
    }
}
