using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = .1f;
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up, speed); 
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down, speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, speed);
        }
    }
}
