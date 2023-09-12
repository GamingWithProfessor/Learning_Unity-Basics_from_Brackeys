using UnityEngine;

public class PlayerCollosion : MonoBehaviour
{
   public PlayerMovement movement;
   void OnCollisionEnter (Collision collisionInfo)
   {
    if (collisionInfo.collider.tag == "Obstacle")
    {
      movement.enabled = false;
    }
   }
}