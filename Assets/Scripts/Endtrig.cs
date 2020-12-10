using UnityEngine;

public class Endtrig : MonoBehaviour
{
    public gamemanager Gamemanager;
    public void OnTriggerEnter()
    {
        Gamemanager.comlvl();
    }
}
