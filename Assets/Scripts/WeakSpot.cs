using UnityEngine;

public class WeakSpot : MonoBehaviour
{
    public GameObject objectToDestroy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(objectToDestroy);
        }
    }
}
