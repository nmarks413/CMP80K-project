using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [Range(1, 10)]
    public float speed;

    [Range(0, 50)]
    public int animFramerate;

    public Sprite stillVert;

    public Sprite[] horizAnimSprite;
    public Sprite[] upAnimSprite;
    public Sprite[] downAnimSprite;

    private SpriteRenderer spriteRenderer;

    private KeyCode prevDirection;
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
        prevDirection = KeyCode.W;
    }


#pragma warning disable CS8321 // Local function is declared but never used
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            UpdatePosition(Vector3.up, KeyCode.W, UpAnimate);

        }
        else if (Input.GetKey(KeyCode.A))
        {
            UpdatePosition(Vector3.left, KeyCode.A, HorizontalAnimate);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            UpdatePosition(Vector3.down, KeyCode.S, DownAnimate);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            UpdatePosition(Vector3.right, KeyCode.D, HorizontalAnimate);
        }
        else
        {
            if (prevDirection == KeyCode.D || prevDirection == KeyCode.A)
                spriteRenderer.sprite = horizAnimSprite[0];
            if (prevDirection == KeyCode.W || prevDirection == KeyCode.S)
                spriteRenderer.sprite = stillVert;
            gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }
#pragma warning restore CS8321 // Local function is declared but never used
    void UpdatePosition(Vector3 direction, KeyCode key, Action animate)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = direction * speed;

        if (prevDirection != key)
        {
            if (key == KeyCode.D)
            {
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else if (key == KeyCode.A)
            {
                transform.localRotation = Quaternion.Euler(0, 180, 0);
            }
            prevDirection = key;
        }
        animate();
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

            if (animationStatusVertUp == 8)
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
