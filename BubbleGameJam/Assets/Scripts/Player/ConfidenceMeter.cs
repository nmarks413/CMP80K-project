using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfidenceMeter : MonoBehaviour
{
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("ConfidenceMet").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
