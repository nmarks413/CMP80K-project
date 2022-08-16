using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfidenceMeter : MonoBehaviour
{
    private Text tempConfidence;
    public int confidence;
    // Start is called before the first frame update
    void Start()
    {
        confidence = 100;
        tempConfidence = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tempConfidence.text = confidence.ToString();
    }
}
