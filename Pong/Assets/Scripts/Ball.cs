using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class Ball : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text AIScoreText;

    int playerScore = 0;
    int AIScore = 0;

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

    //When the ball hits the green square increase the score and respawn the ball in the middle.
    void OnTriggerEnter2D(Collider2D collision)
    {
        //If the ball goes in the green rectangle behind the AI paddle.
        if (collision.name == "PlayerScore")
        {
            playerScore++;
            playerScoreText.text = playerScore.ToString();
            Debug.Log("Player Score");
        }
        //If the ball goes in the green rectangle behind the player paddle.
        if (collision.name == "AIScore")
        {
            AIScore++;
            Debug.Log("AI Score");
            AIScoreText.text = playerScore.ToString();
        }

        //Reset ball in the middle of the screen.
        transform.position = Vector3.zero;
        rigidbody.AddForce(transform.up * speed, ForceMode2D.Impulse);

    }
}
