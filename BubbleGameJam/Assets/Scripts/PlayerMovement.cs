using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0, 1)]
    public float speed;

    [Range(0, 50)]
    public int animFramerate;

    public Sprite tempFacingSprite;

    public Sprite[] animSprite;
    private SpriteRenderer spriteRenderer;

    private char prevDirection;
    private int animationStatus;

    private int gameFramesToAnimFrames;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animationStatus = 0;
        prevDirection = 'W';
    }
    private void FixedUpdate() //W and S are subject to change
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up, speed);
            spriteRenderer.sprite = tempFacingSprite;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.left, speed);

            if (prevDirection != 'A')
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
                prevDirection = 'A';
            }

            HorizontalAnimate();
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down, speed);
            spriteRenderer.sprite = tempFacingSprite;
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.right, speed);

            if (prevDirection != 'D')
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
                prevDirection = 'D';
            }

            HorizontalAnimate();
        }
    }

    void HorizontalAnimate()
    {

        gameFramesToAnimFrames++;

        if (gameFramesToAnimFrames >= 50/animFramerate)
        {
            spriteRenderer.sprite = animSprite[animationStatus];
            animationStatus++;

            if (animationStatus == 10)
            {
                animationStatus = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

}