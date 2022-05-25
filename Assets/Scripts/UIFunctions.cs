using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFunctions : Singleton<UIFunctions>
{
    public void GasPressed()
    {
        WheelController.Instance.speed = WheelController.Instance.start;
    }

    public void GasReleased()
    {
        WheelController.Instance.speed = WheelController.Instance.stop;
    }


    public void BreakPressed()
    {
        WheelController.Instance.breakPressed = true;
    }

    public void BreakReleased()
    {
        WheelController.Instance.breakPressed = false;
    }

    public void Reverse()
    {
        WheelController.Instance.speed = -WheelController.Instance.start;
    }

    public void LiftUp()
    {
        LiftMovement.Instance.liftUpCalled = true;
        LiftMovement.Instance.liftDownCalled = false;

    }

    public void LiftDown()
    {
        LiftMovement.Instance.liftDownCalled = true;
        LiftMovement.Instance.liftUpCalled = false;
    }
}
