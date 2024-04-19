using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Vector3 for going up and down
    Vector3 speedUp = Vector3.up;
    Vector3 speedDown = Vector3.down;
    // Update is called once per frame
    void FixedUpdate()
    {
        //If player hits up arrow move paddle up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += speedUp * 0.1f;
        }
        //If player hits down arrow move the paddle down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += speedDown * 0.1f;
        }
    }
}
