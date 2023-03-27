using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu1 : MonoBehaviour
{
    public int gameStartScene;

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
