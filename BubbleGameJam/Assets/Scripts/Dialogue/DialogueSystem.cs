using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    private float radius;

    private GameObject player;

    private bool instantiated;
    
    private void Start()
    {
        radius = 2.5f;

        player = GameObject.Find("Player");

        instantiated = false;
    }

    private void FixedUpdate()
    {
        if(Vector3.Distance(player.transform.position, transform.position) < radius)
        {
            if(!instantiated)
            {
                DrawDialogue();
                instantiated = true;
            }
        }
    }

    private void DrawDialogue()
    {
        for(int i = 0; i < 3; i++)
        {
            CreateBubble(new GameObject(), i);
        }
    }

    private void CreateBubble(GameObject newBubble, int i)
    {
        switch(i)
        {
            case 0:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/rawr_xd");
                newBubble.transform.position = transform.position + new Vector3(1, 0.75f, -2);
                break;
            case 1:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/school_chem");
                newBubble.transform.position = transform.position + new Vector3(-1f, 0.75f, -2);
                break;
            case 2:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/weather");
                newBubble.transform.position = transform.position + new Vector3(0f, 1.25f, -2);
                break;
        }
    }
}
