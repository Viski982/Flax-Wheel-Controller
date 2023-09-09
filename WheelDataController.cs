using FlaxEngine;

public class WheelDataController : Script
{
    private WheeledVehicle veh;

    [Header("Steering")]
    public float maxSteerAngle = 20f;
    public float dampingRate = 0.25f;
    public float maxBrakeTorque = 1500;
    public float maxHandBrakeTorque = 2000;
    [Space(2)]
    [Header("Suspension")]
    public float suspensionDampingRate = 2f;
    public float suspensionMaxRaise = 10;
    public float suspensionMaxDrop = 10f;
    public float suspensionForceOffset = 0f;
    [Space(2)]
    [Header("Tire")]
    public float tireLateralStiffness = 17f;
    public float tireLateralMax = 2f;
    public float tireLongitudinalStiffness = 1000f;
    public float tireFrictionScale = 100f;


    public override void OnAwake()
    {
        veh = Actor.As<WheeledVehicle>();
    }

    // You can put inside OnUpdate() if you want so you can change the values at runtime :D

    public override void OnStart()
    {
        for (int i = 0; i < veh.Wheels.Length; i++)
        {
            WheeledVehicle.Wheel wheel = veh.Wheels[i];
            wheel.MaxSteerAngle = maxSteerAngle;
            wheel.DampingRate = dampingRate;
            wheel.MaxBrakeTorque = maxBrakeTorque;
            wheel.MaxHandBrakeTorque = maxHandBrakeTorque;
            wheel.SuspensionDampingRate = suspensionDampingRate;
            wheel.SuspensionForceOffset = suspensionForceOffset;
            wheel.SuspensionMaxDrop = suspensionMaxDrop;
            wheel.SuspensionMaxRaise = suspensionMaxRaise;
            wheel.TireLateralStiffness = tireLateralStiffness;
            wheel.TireLateralMax = tireLateralMax;
            wheel.TireLongitudinalStiffness = tireLongitudinalStiffness;
            wheel.TireFrictionScale = tireFrictionScale;
            veh.Wheels[i] = wheel;
        }
        veh.Setup(); // DON'T REMOVE THIS
    }
}

// Special thanks to Withaust <3
