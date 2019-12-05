using System;
using UnityEngine;


// Enums: https://www.dotnetperls.com/enum

/// <summary>
/// 
/// </summary>
public enum ClawGripState
{
    Open,
    Closed
}


public enum ArmMovementState
{
    Stopped,
    Moving
}


/// <summary>
/// Provides positional data of claw world location
/// Provides state data of claw grip
/// </summary>
public class RoboClawAssembly : MonoBehaviour
{
    /// <summary>
    /// Offset from gameObject.Transform.position to where claw grips
    /// </summary>
    private GameObject clawPickupPosition;

    ClawGripState clawGripState = ClawGripState.Open;
    ArmMovementState armMovementState = ArmMovementState.Stopped;

    [SerializeField]
    private GameObject pickUpObject;

    public Vector3 ClawPosition
    {
        get
        {
            return clawPickupPosition.transform.position;
        }
    }

    public GameObject PickUpObject
    {
        get
        {
            return pickUpObject;
        }
    }

    public ClawGripState ClawGripState
    {
        get
        {
            return clawGripState;
        }

        set
        {
            if (clawGripState == ClawGripState.Closed 
                && value == ClawGripState.Open
                && pickUpObject != null)
            {
                NotifyPickUpObjectDropped();
            }
            clawGripState = value;
        }
    }

    public ArmMovementState ArmMovementState
    {
        get
        {
            return armMovementState;
        }

        set
        {
            armMovementState = value;
        }
    }

    public void Awake()
    {
        clawPickupPosition = transform.Find("ClawPickupPosition").gameObject;
        
        if (clawPickupPosition == null)
        {
            throw new Exception(name + " does not have a ClawPickupPosition child object assigned");
        }
    }

    public void Update()
    {
        switch(ArmMovementState)
        {
            case ArmMovementState.Stopped:
                // Nothing
                break;
            case ArmMovementState.Moving:
                UpdateMovement();
                break;
            default:
                Debug.LogWarning("Unassgined ArmMovementState");
                break;
        }
    }

    private void NotifyPickUpObjectDropped()
    {
        throw new NotImplementedException();
    }

    private void UpdateMovement()
    {
        if (PickUpObject != null && ClawGripState == ClawGripState.Closed)
        {
            pickUpObject.transform.position = ClawPosition;
        }
    }
}





