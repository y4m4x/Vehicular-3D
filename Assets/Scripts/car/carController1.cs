using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carControllerPJ1 : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backLeftTransform;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {
        currentAcceleration = acceleration * Input.GetAxis("VerticalPJ1");

        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;

        else
            currentBreakForce = 0;

        backLeft.motorTorque = currentAcceleration;
        backRight.motorTorque = currentAcceleration;

        frontLeft.brakeTorque = currentBreakForce;
        frontRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("HorizontalPJ1");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;

        updatewheel(frontLeft, frontLeftTransform);
        updatewheel(frontRight, frontRightTransform);
        updatewheel(backLeft, backRightTransform);
        updatewheel(backRight, backLeftTransform);
    }
    void updatewheel(WheelCollider col, Transform trans)
    {
        Vector3 Position;
        Quaternion rotation;
        col.GetWorldPose(out Position, out rotation);
        trans.position = Position;
        trans.rotation = rotation;
    }

}

