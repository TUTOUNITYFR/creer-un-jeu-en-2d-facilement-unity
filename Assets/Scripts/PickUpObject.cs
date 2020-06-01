using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.AddCoins(1);
            CurrentSceneManager.instance.coinsPickedUpInThisSceneCount++;
            Destroy(gameObject);
        }
    }
}
