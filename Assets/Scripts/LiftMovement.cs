using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftMovement : Singleton<LiftMovement>
{
    public bool liftUpCalled;
    public bool liftDownCalled;
    public float speed = 1.5f;
    public float liftPositionUp = 7.5f;
    public float liftPositionDown = 2.5f;
    public Transform lift;

    private void FixedUpdate()
    {
        if (liftUpCalled && lift.transform.position.y < liftPositionUp)
        {

            lift.transform.position += Vector3.up * Time.deltaTime * speed;
            
        }
      
        if (liftDownCalled && lift.transform.position.y > liftPositionDown)
        {
           
            lift.transform.position += Vector3.down * Time.deltaTime * speed;
            
        }       
    }
}
