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
    private Vector3 spawnPosition;

    public float interactRange = 4.0f;

    public void LoadPlayback(List<PlayerInputFrame> inputs, Vector3 spawnPosition)
    {
        playbackInputs = inputs;
        playbackStartTime = Time.time;
        this.spawnPosition = spawnPosition;
        transform.position = spawnPosition;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (playbackInputs == null) return;
        if (currentFrame >= playbackInputs.Count)
        {
            LoadPlayback(playbackInputs,spawnPosition);
            currentFrame = 0;
            return;
        }

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

            if (input.interact)
            {
               
                TryInteractWithObjectInRange();
            }

            if (isGrounded) jumpNumber = 1;

            currentFrame++;
        }
    }

    void TryInteractWithObjectInRange()
    {
        Debug.Log(transform.position);
        
        Collider2D[] hitColliders = Physics2D.OverlapCircleAll(transform.position, interactRange);

        Debug.Log(hitColliders.Length);

        foreach (var hit in hitColliders)
        {
            Debug.Log("olalolilela");
            var interactable = hit.GetComponent<IInteractor>();

            if (interactable != null)
            {
                interactable.Interact();
                break;
            }
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
