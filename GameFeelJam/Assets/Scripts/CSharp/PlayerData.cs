using UnityEngine;

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
}
