using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Range(0.05f, 0.1f)]
    public float threshhold;

    private void FixedUpdate()
    {
        if (transform.position.x > -3 && transform.position.x < 31)
        {

            if (transform.position.x - Camera.main.transform.position.x > threshhold)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + threshhold, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            else if (transform.position.x - Camera.main.transform.position.x < -threshhold)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x - threshhold, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
        }
        if (transform.position.y < -1 && transform.position.y > -3)
        {
            if (transform.position.y - Camera.main.transform.position.y > threshhold)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y + threshhold, Camera.main.transform.position.z);
            }
            else if (transform.position.y - Camera.main.transform.position.y < -threshhold)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, Camera.main.transform.position.y - threshhold, Camera.main.transform.position.z);
            }
        }
    }
}
