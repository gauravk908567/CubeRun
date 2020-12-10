using UnityEngine;
using UnityEngine.SceneManagement;
public class gamemanager : MonoBehaviour
{
    bool gameend = false;
    public float redel = 1f;

    public GameObject complvlui;

    public void comlvl()
    {
        complvlui.SetActive(true);
    }

    public void endgame()
    {
        if (gameend == false)
        {
            gameend = true;
            Debug.Log("Game Over");
            Invoke("restart", redel);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}