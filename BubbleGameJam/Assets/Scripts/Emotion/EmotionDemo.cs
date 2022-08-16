using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Player").GetComponent<SpriteRenderer>().color = Color.yellow;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
