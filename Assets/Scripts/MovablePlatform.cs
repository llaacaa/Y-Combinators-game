using UnityEngine;

public class MovablePlatform : MonoBehaviour
{
    public Vector3 moveOffset = new Vector3(0, 3f, 0);
    public float moveDuration = 1f;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool isMoving = false;
    private float timer = 0f;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + moveOffset;
    }

    public void Activate()
    {
        isMoving = true;
        timer = 0f;
    }

    void Update()
    {
        if (isMoving)
        {
            timer += Time.deltaTime;
            float t = timer / moveDuration;
            transform.position = Vector3.Lerp(startPosition, targetPosition, t);

            if (t >= 1f)
            {
                isMoving = false;
            }
        }
    }
}
