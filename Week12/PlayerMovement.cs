using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    private float speedX = 0f;
    private float speedY = 0f;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    public Sprite idle;
    public Sprite run;
    public Sprite jump;
    public Sprite fall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {

        // Horizontal Movement
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            transform.localScale = new Vector3(-3f, 3f, 1f);
            spriteRenderer.sprite = run;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            transform.localScale = new Vector3(3f, 3f, 1f);
            spriteRenderer.sprite = run;
        }
        else
        {
            speedX = 0;
            spriteRenderer.sprite = idle;
        }

        // Vertical Movement
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = jump;

        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = fall;
        }
        else
        {
            speedY = 0;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
