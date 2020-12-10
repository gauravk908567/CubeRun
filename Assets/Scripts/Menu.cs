using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
public void startgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
