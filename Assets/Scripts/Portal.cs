using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform targetPortal;
    private bool canTeleport = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("jel radi");
        if (other.CompareTag("Player") && canTeleport)
        {
            
            other.transform.position = targetPortal.position;

            Portal targetScript = targetPortal.GetComponent<Portal>();
            if (targetScript != null)
            {
                targetScript.canTeleport = false;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canTeleport = true; 
        }
    }
}
