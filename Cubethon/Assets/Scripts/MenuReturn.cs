using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuReturn : MonoBehaviour
{
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }

}

