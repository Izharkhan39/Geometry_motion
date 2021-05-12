using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{   //public rigibody is ref in unity and rb i name
    // forwarF & SideF is instances 
    public Rigidbody rb;
    public  float forwardforce =2000f;
    public float sidewayforce = 500f;
   
    void Update()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        //this code is for constant for in z direc
        //TIme.deltaTime if framerate 
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);//forcemode.velocitychange adds a instant velocity change,ignoring its mass   
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        



        
    }
}
