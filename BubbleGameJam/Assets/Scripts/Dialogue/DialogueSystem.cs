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

    private void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < radius)
        {
            if (!instantiated)
            {
                if(Input.GetMouseButton(0))
                {
                    DrawDialogue();
                    instantiated = true;
                }
            }
        }
    }

    private void DrawDialogue()
    {
        for (int i = 0; i < 3; i++)
        {
            CreateBubble(new GameObject(), i);
        }
    }

    private void CreateBubble(GameObject newBubble, int i)
    {
        GameObject speechBubble = new GameObject();

        switch (i)
        {
            case 0:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/rawr_xd");
                newBubble.transform.position = transform.position + new Vector3(1, 1.0f, -2);
                newBubble.name = "rawr_xd";
               
                speechBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/left_speech");
                speechBubble.transform.localRotation = Quaternion.Euler(0, 180, 0);
                speechBubble.transform.position = transform.position + new Vector3(1f, 0.85f, -1);
                break;
            case 1:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/school_chem");
                newBubble.transform.position = transform.position + new Vector3(-1f, 1.1f, -2);
                newBubble.name = "school_chem";

                speechBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/left_speech");
                speechBubble.transform.position = transform.position + new Vector3(-1f, 0.85f, -1);
                break;
            case 2:
                newBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/weather");
                newBubble.transform.position = transform.position + new Vector3(0f, 1.45f, -2);
                newBubble.name = "weather";

                speechBubble.AddComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("DialogueSystem/mid_speech");
                speechBubble.transform.position = transform.position + new Vector3(0f, 1.35f, -1);
                break;
        }

        newBubble.AddComponent<BoxCollider2D>();
    }
}
