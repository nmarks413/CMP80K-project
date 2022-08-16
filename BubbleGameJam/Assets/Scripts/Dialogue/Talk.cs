using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : MonoBehaviour
{
    public float radius = 0.5f; // TODO:Implement actual value 
    private GameObject player;
    private GameObject pbuddy;
    public Vector3 offset1 = new Vector3(0, 0, 0);
    public Vector3 offset2 = new Vector3(0, 0, 0);
    public Vector3 offset3 = new Vector3(0, 0, 0);
    private GameObject bubble1;
    private GameObject bubble2;
    private GameObject bubble3;

    private void Start()
    {
        player = GameObject.Find("Player");
        pbuddy = GameObject.Find("Pbuddy");
    }
    private void Update()
    {
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
        //bubble1.GetComponent<SpriteRenderer>().sprite = ;
    }
    void CheckBubbleHover(GameObject bubble)
    {
        if(player.transform.position == bubble.transform.position)
        {
            //TODO: Do some sort of bounce animation
        }
    }

}
