using UnityEngine;

public class DontDestroyOnLoadScene : MonoBehaviour
{

    public GameObject[] objects;

    void Awake()
    {
        foreach (var element in objects)
        {
            DontDestroyOnLoad(element);
        }
    }
}
