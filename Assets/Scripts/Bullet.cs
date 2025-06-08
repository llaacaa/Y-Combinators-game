using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;

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
        Destroy(gameObject);
        Debug.Log("IS THIS CORRECT " +  collision.gameObject.name);
        if (collision.gameObject.name == "character (4)(Clone)")
        {
            Destroy(collision.gameObject);
        }
    }
}
