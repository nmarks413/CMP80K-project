using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{
    [Range(0.05f, 0.1f)]
    public float threshhold;

    private void FixedUpdate()
    {
        if (transform.position.x > -3 && transform.position.x < 31 || SceneManager.GetActiveScene().name != "demoScene")
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
        if (transform.position.y < -1 && transform.position.y > -3 || SceneManager.GetActiveScene().name != "demoScene")
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
