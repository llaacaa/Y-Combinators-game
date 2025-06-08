using UnityEngine;

public class PortalBeam : MonoBehaviour
{
    public float lifeTime = 3f;
    public GameObject portalPrefab;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Calculate the new position of the portal
        Vector3 newPos = transform.position;
        newPos.x -= 8f;

        // Instantiate the portal prefab
        GameObject newPortal = Instantiate(portalPrefab, newPos, Quaternion.identity);

        GlobalState.portals.Add(newPortal);

        // If the portal has a Rigidbody2D, set gravity to 0
        Rigidbody2D rb = newPortal.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = 0f;
        }

        // Find the child (Plane.004) and offset it by 8 units along x
        Transform planeChild = newPortal.transform.Find("Plane.004");
        if (planeChild != null)
        {
            Vector3 childPos = planeChild.localPosition;
            childPos.x -= 7f; // offset relative to the parent
            planeChild.localPosition = childPos;
        }

        if (GlobalState.portals.Count == 2)
        {
            GlobalState.linkPortals();
        }

        // Destroy the beam
        Destroy(gameObject);
    }

}
