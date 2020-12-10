using UnityEngine;

public class playerMov : MonoBehaviour

{

    public Rigidbody rb;

    public float fwdd = 2000f;

    public float sdf = 500f;

    //we are usign fixedupdate because we are using it for unity physics

    void FixedUpdate()
    {
        //Add a forward Force
        rb.AddForce(0, 0, fwdd*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sdf * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sdf * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y< -1f)
        {
            FindObjectOfType<gamemanager>().endgame();
        }
    }
}
