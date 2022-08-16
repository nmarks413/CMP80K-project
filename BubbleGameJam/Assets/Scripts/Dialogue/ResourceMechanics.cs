using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceMechanics : MonoBehaviour
{
    private int confidence;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        confidence = 10;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                if (hit.collider.name == "weather")
                {
                    confidence -= 1;
                }
                else if (hit.collider.name == "rawr_xd")
                {
                    confidence -= 5;
                }
                else if(hit.collider.name == "school_chem")
                {
                    confidence -= 2;
                }
            }
            if(confidence > 7)
            {
                spriteRenderer.color = Color.yellow;
            }
            else if(confidence > 4)
            {
                spriteRenderer.color = Color.blue;
            }
            else if(confidence > 2)
            {
                spriteRenderer.color = Color.green;
            }
            else
            {
                spriteRenderer.color = Color.black;
            }
        }
    }
}
