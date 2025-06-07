using System.Collections.Generic;
using UnityEngine;

public class ShadowPlayback : MonoBehaviour
{
    private List<PlayerInputFrame> playbackInputs;
    private Rigidbody2D rb;
    private float playbackStartTime;
    private int currentFrame = 0;

    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded;

    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;
    public int jumpNumber = 1;

    public void LoadPlayback(List<PlayerInputFrame> inputs)
    {
        playbackInputs = inputs;
        playbackStartTime = Time.time;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (playbackInputs == null || currentFrame >= playbackInputs.Count) return;

        float elapsedTime = Time.time - playbackStartTime;

        while (currentFrame < playbackInputs.Count &&
               playbackInputs[currentFrame].time - playbackInputs[0].time <= elapsedTime)
        {
            PlayerInputFrame input = playbackInputs[currentFrame];
            rb.linearVelocity = new Vector2(input.horizontal * moveSpeed, rb.linearVelocity.y);

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            if (input.jump && (isGrounded || jumpNumber > 0))
            {
                rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
                jumpNumber--;
            }

            if (isGrounded) jumpNumber = 1;

            currentFrame++;
        }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }
}
