using UnityEngine;
using UnityEngine.SceneManagement;
public class complete : MonoBehaviour
{
    public void loadnextlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
