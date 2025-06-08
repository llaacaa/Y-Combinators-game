using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] public Transform destinationPortal;
    [SerializeField] private float cooldownTime = 0.1f;
    static private bool isPortalDisabled = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);

        if (collision.name.StartsWith("character") && !isPortalDisabled)
        {
            Transform characterTransform = collision.transform;

            // Teleport to destination portal's position
            Vector3 newPosition = characterTransform.position;
            newPosition.x = destinationPortal.position.x;
            newPosition.y = destinationPortal.position.y;
            characterTransform.position = newPosition;

            // Disable portals temporarily
            StartCoroutine(DisablePortalTemporarily());
        }
    }

    private System.Collections.IEnumerator DisablePortalTemporarily()
    {
        isPortalDisabled = true;
        yield return new WaitForSeconds(cooldownTime);
        isPortalDisabled = false;
    }
}