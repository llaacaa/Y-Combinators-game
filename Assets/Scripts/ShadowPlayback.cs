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
    public LayerMask platformLayer;
    public int jumpNumber = 1;
    private Vector3 spawnPosition;

    public float interactRange = 4.0f;

    private Animator animator;

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
        animator = GetComponent<Animator>();
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

            animator.SetFloat("Speed", Mathf.Abs(input.horizontal));

            if (input.horizontal > 0)
            {
                transform.rotation = Quaternion.Euler(0, 128, 0);
            }
            else if (input.horizontal < 0)
            {
                transform.rotation = Quaternion.Euler(0, 229, 0);
            }

            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            if(!isGrounded)isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, platformLayer);
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "character (4)(Clone)" || collision.gameObject.name == "character (3)")
        {
            GlobalState.isGameOver = true;
        }
    }
}
