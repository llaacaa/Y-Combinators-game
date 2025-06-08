using UnityEngine;

public class ButtonTrigger : MonoBehaviour , IInteractor
{
    public MovablePlatform platformToActivate;
    private bool playerInRange = false;

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.F))
        {
            platformToActivate.Activate();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

   

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    public void Interact()
    {
        Debug.Log("usao");
        platformToActivate.Activate();
    }
}