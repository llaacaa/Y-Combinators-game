using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;

    public Transform firePointLeft;

    public Transform firePointRight;

    public GameObject bulletPrefab;
    public float bulletSpeed = 10f; // ADDED THIS
    public Transform groundCheck;
    public float groundCheckRadius = 0.1f;
    public LayerMask groundLayer;
    public int jumpNumber = 0;

<<<<<<< Updated upstream
=======
    private Animator animator;
>>>>>>> Stashed changes

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }

        float moveX = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveX * moveSpeed, rb.linearVelocity.y); 

<<<<<<< Updated upstream
=======
        animator.SetFloat("Speed", Mathf.Abs(moveX));

        if (moveX > 0)
        {
            transform.rotation = Quaternion.Euler(0, 128, 0);
        }
        else if (moveX < 0)
        {
            transform.rotation = Quaternion.Euler(0, 229, 0);
        }

>>>>>>> Stashed changes
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpNumber > 0))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            jumpNumber--;
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if (isGrounded) { jumpNumber = 1; }
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
        }
    }

    void Fire()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0f;

        Transform chosenFirePoint = (mouseWorldPos.x >= transform.position.x) ? firePointRight : firePointLeft;


        Vector3 rawDirection = mouseWorldPos - chosenFirePoint.position;
        float currentLength = Mathf.Sqrt(rawDirection.x * rawDirection.x + rawDirection.y * rawDirection.y);

        Vector3 direction = rawDirection / currentLength; // Normalizacija
        float factor = bulletSpeed*5 / currentLength;

        Vector2 velocity = new Vector2(rawDirection.x * factor, rawDirection.y * factor);

        GameObject bullet = Instantiate(bulletPrefab, chosenFirePoint.position, Quaternion.identity);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.gravityScale = 0f;

        bulletRB.linearVelocity = velocity;

        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
        bullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

}