using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            LoadMainMenu();
        }
    }
}
