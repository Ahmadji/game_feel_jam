using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    [Header("Player Settings")]
    [Space, Range(1, 10)]
    public float rotationXSpeed;
    [Space, Range(1, 10)]
    public float rotationYSpeed;

    [Header("Player State")]
    public bool isGrounded;
    public bool canDash = true;
    public bool isBreathHolding = false;
    public bool Wallrunning = false;
    public bool canHarvest = false;
    public bool canDie = false;
    public bool isSliding = false;

    [Header("Player Movement")]
    [Tooltip("The higher it is, the faster the player will reach full speed")]
    public float acceleration = 5f;
    [Tooltip("Max Speed on the xz plan")]
    public float maxSpeedXZ = 15f;
    [Tooltip("Max Speed on the y axis")]
    public float maxSpeedY = 30f;
    [Tooltip("Jump Height in meters")]
    public float jumpHeight = 3f;
    [Tooltip("Amplitude of the force opposing the movement")]
    public float brakingAmplitude = 10f;
    [Tooltip("Time to reach full stop after releasing all keys")]
    public float stopTime = 3f;
    [HideInInspector]
    public int numKeyPressed = 0;
    [HideInInspector]
    public float stopTimer = 0;

    [Header("Player Dash")]
    public float dashAmplitude = 15f;
    public float dashCooldown = 0f;

    [Header("Oxygen System")]
    public float o2DecreaseBreathing = 0.5f;
    public float o2DecreaseRunning = 0.25f;
    public int o2DecreaseDash = 20;
    public int o2DecreaseJump = 5;
    public int o2PerCapsules = 20;
    public float breathHoldingDuration = 10f;
    [HideInInspector]
    public List<int> o2Capsules;
    [HideInInspector]
    public float durationCooldown = 0.5f;
    [HideInInspector]
    public int numMaxCapsules = 5;
    [HideInInspector]
    public int subtractRest = 0;
    [HideInInspector]
    public int subtractAction = 0;
    [HideInInspector]
    public int o2Index = 0;
    [HideInInspector]
    public int capsuleLeft = 0;

    [Header("WallRun")]
    public float WallRunSpeed = 10f;
}
