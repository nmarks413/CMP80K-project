using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public float radius;
    private GameObject player;
    private GameObject pbuddy;
    public Vector3 offset1 = new Vector3(0.1f, 0.2f, 0);
    public Vector3 offset2 = new Vector3(0.1f, -0.2f, 0);
    public Vector3 offset3 = new Vector3(0.1f, 0.1f, 0);
    private GameObject bubble1;
    private GameObject bubble2;
    private GameObject bubble3;
    private Sprite sprite1;
    private Sprite sprite2;
    private Sprite sprite3;

    private void Start()
    {
        radius = 2.5f;
        player = GameObject.Find("Player");
        pbuddy = GameObject.Find("otherNPC");
        sprite1 = Resources.Load<Sprite>("DialogueSystem/rawr_xd");
        sprite2 = Resources.Load<Sprite>("DialogueSystem/school_chem");
        sprite3 = Resources.Load<Sprite>("DialogueSystem/weather");


    }
    private void Update()
    {
        //Debug.Log(Vector3.Distance(player.transform.position, pbuddy.transform.position));
        if (Vector3.Distance(player.transform.position, pbuddy.transform.position) < radius){
            if (!bubble1) {
                DrawTalkBubble(pbuddy);
            }
            CheckBubbleHover(bubble1);
            CheckBubbleHover(bubble2);
            CheckBubbleHover(bubble3);
            
        }
    }
    void DrawTalkBubble(GameObject npc)
    {
        bubble1 = new GameObject();
        bubble1.AddComponent<SpriteRenderer>();
        bubble1.GetComponent<SpriteRenderer>().sprite = sprite1;
        bubble1.transform.position = offset1 + npc.transform.position + new Vector3(0,0,-1);
        print(bubble1.transform.position);
        bubble2 = new GameObject();
        bubble2.AddComponent<SpriteRenderer>();
        bubble2.GetComponent<SpriteRenderer>().sprite = sprite2;
        bubble2.transform.position = offset2 + npc.transform.position;  
        bubble3 = new GameObject();
        bubble3.AddComponent<SpriteRenderer>();
        bubble3.GetComponent<SpriteRenderer>().sprite = sprite3;
        bubble3.transform.position = offset3 + npc.transform.position;
    }
    void CheckBubbleHover(GameObject bubble)
    {
        if(player.transform.position == bubble.transform.position)
        {
            //TODO: Do some sort of bounce animation
        }
    }

}
