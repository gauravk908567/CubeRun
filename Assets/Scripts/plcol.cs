
using UnityEngine;

public class plcol : MonoBehaviour
{
    public playerMov move;
    
    void OnCollisionEnter(Collision collinfo)
    {
        if (collinfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<gamemanager>().endgame();
        }
    }

  
}
