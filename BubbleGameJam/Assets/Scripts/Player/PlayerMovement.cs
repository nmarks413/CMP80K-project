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
    private int animationStatusVertDown;
    private int animationStatusVertUp;

    private int gameFramesToAnimFrames;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        animationStatusHoriz = 0;
        animationStatusVertDown = 0;
        animationStatusVertUp = 0;
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
            spriteRenderer.sprite = upAnimSprite[animationStatusVertUp];
            animationStatusVertUp++;

            if (animationStatusVertUp == 4)
            {
                animationStatusVertUp = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

    void DownAnimate()
    {
        gameFramesToAnimFrames++;

        if (gameFramesToAnimFrames >= 50 / animFramerate)
        {
            spriteRenderer.sprite = downAnimSprite[animationStatusVertDown];
            animationStatusVertDown++;

            if (animationStatusVertDown == 8)
            {
                animationStatusVertDown = 0;
            }

            gameFramesToAnimFrames = 0;
        }
    }

}