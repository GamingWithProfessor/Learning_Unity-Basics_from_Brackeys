using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this is the reference for regidbody as rb
    public Rigidbody rb;
    public float forwardforce = 500f;
    public float Sidewardforce = 500f;

    // changed update to FixedUpdate because we are playing with the physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);

        if (Input.GetKey("d")) 
        {
         rb.AddForce(Sidewardforce * Time.deltaTime, 0, 0);
        }
          if (Input.GetKey("a")) 
        {
         rb.AddForce(-Sidewardforce * Time.deltaTime, 0, 0);
        }
    }
    
}