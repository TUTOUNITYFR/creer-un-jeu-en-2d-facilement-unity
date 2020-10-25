using UnityEngine;

public class ItemsDatabase : MonoBehaviour
{
    public Item[] allItems;

    public static ItemsDatabase instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de ItemsDatabase dans la scène");
            return;
        }

        instance = this;
    }
}
