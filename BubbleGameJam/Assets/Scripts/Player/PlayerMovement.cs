using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(0, 1)]
    public float speed;

    [Range(0, 50)]
    public int animFramerate;

    public Sprite[] horizAnimSprite;
    public Sprite[] upAnimSprite;
    public Sprite[] downAnimSprite;

    private SpriteRenderer spriteRenderer;

    private char prevDirection;
    private int animationStatusHoriz;
    private int animationStatusVert;

    private int gameFramesToAnimFrames;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animationStatusHoriz = 0;
        animationStatusVert = 0;
        prevDirection = 'W';
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.up, speed);

            if(prevDirection != 'W')
            {
                prevDirection = 'W';
            }

            UpAnimate();
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

            if(prevDirection != 'S')
            {
                prevDirection = 'S';
            }

            DownAnimate();
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
        else
        {
            if (prevDirection == 'D' || prevDirection == 'A')
                spriteRenderer.sprite = horizAnimSprite[0];
            if (prevDirection == 'W' || prevDirection == 'S')
                spriteRenderer.sprite = upAnimSprite[0];
        }
    }

    void HorizontalAnimate()
    {

        gameFramesToAnimFrames++;

        if (gameFramesToAnimFrames >= 50 / animFramerate)
        {
            spriteRenderer.sprite = horizAnimSprite[animationStatusHoriz];
            animationStatusHoriz++;

            if (animationStatusHoriz == 10)
            {
                animationStatusHoriz = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

    void UpAnimate()
    {
        gameFramesToAnimFrames++;

        if (gameFramesToAnimFrames >= 50 / animFramerate)
        {
            spriteRenderer.sprite = upAnimSprite[animationStatusVert];
            animationStatusVert++;

            if (animationStatusVert == 4)
            {
                animationStatusVert = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

    void DownAnimate()
    {
        gameFramesToAnimFrames++;

        if (gameFramesToAnimFrames >= 50 / animFramerate)
        {
            spriteRenderer.sprite = downAnimSprite[animationStatusVert];
            animationStatusVert++;

            if (animationStatusVert == 4)
            {
                animationStatusVert = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

}