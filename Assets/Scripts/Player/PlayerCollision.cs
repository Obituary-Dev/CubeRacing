using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Obstacle")
        {
            PlayerMovement.isOnTheGround = true;
        }
 
        if(collision.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
