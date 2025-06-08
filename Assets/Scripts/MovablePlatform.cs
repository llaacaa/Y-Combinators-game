using UnityEngine;

public class MovablePlatform : MonoBehaviour
{
    public float moveDistance = 2f;         // visina podizanja (podesivo u Editoru)
    public float moveDuration = 1f;         // koliko traje podizanje ili spuštanje
    public float waitTime = 2f;             // koliko da čeka gore

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private float timer = 0f;
    private enum State { Idle, MovingUp, Waiting, MovingDown }
    private State currentState = State.Idle;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + new Vector3(0, moveDistance, 0);
    }

    public void Activate()
    {
        if (currentState == State.Idle)
        {
            currentState = State.MovingUp;
            timer = 0f;
        }
    }

    void Update()
    {
        switch (currentState)
        {
            case State.MovingUp:
                timer += Time.deltaTime;
                float tUp = timer / moveDuration;
                transform.position = Vector3.Lerp(startPosition, targetPosition, tUp);
                if (tUp >= 1f)
                {
                    transform.position = targetPosition;
                    currentState = State.Waiting;
                    timer = 0f;
                }
                break;

            case State.Waiting:
                timer += Time.deltaTime;
                if (timer >= waitTime)
                {
                    currentState = State.MovingDown;
                    timer = 0f;
                }
                break;

            case State.MovingDown:
                timer += Time.deltaTime;
                float tDown = timer / moveDuration;
                transform.position = Vector3.Lerp(targetPosition, startPosition, tDown);
                if (tDown >= 1f)
                {
                    transform.position = startPosition;
                    currentState = State.Idle;
                    timer = 0f;
                }
                break;
        }
    }
}
