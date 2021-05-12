using UnityEngine;

public class playercollision : MonoBehaviour
{
    public playermovement movement;
   
    // ref of playermovement in player collision
     

    private void OnCollisionEnter(Collision collisioinfo )//OnCollisionEnter will not work if 'is Trigger' is on
    {
        if (collisioinfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); 


            



            //when it hit the obstacle the playermovement script will be disabled
        }  
       
    }





}
