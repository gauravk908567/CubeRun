
using UnityEngine;

public class flwplr : MonoBehaviour
{

    public Transform Player;
    public Vector3 offset;

    void Update()
    {
        transform.position = Player.position + offset;
    }
}
