using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : Singleton<WheelController>
{

    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;

    private Rigidbody forkliftRb;

    public bool breakPressed;  
    public float acceleration = 1000f;
    public float breakingForce = 3000f;
    public float maxTurnAngle = 30f;
    public float speed;
    public float stop = 0f;
    public float start = 10f;
    private float currentTurnAngle = 0f;

    private void Start()
    {
        forkliftRb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        
        Gas();
        Break();
        TurnAngle();
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(backRight, backRightTransform);
        UpdateWheel(backLeft, backLeftTransform);

    }

    public void Gas()
    {
        frontRight.motorTorque = acceleration * speed;
        frontLeft.motorTorque = acceleration * speed;
    }

    public void Break()
    {
        if (breakPressed && forkliftRb.velocity != Vector3.zero)
        {
            forkliftRb.velocity = 0.99f * Time.deltaTime * forkliftRb.velocity;
        }
    }

    private void UpdateWheel(WheelCollider wCollider, Transform wTransform)
    {
        Vector3 pos;
        Quaternion rot;
        wCollider.GetWorldPose(out pos, out rot);
        wTransform.rotation = rot;
        wTransform.position = pos;
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Space"))
        {
            SceneManager.Instance.RestartScene();
        }
        else if (other.CompareTag("Enemy"))
        {
            SceneManager.Instance.RestartScene();
        }
        else if (other.CompareTag("Ground"))
        {
            //Debug.Log("Touching ground");
        }

    }
        
    public void TurnAngle()
    {
        currentTurnAngle = maxTurnAngle * SteeringWheel.steeringInput;
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;
    }






}
