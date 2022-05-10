using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    [Header("Player Settings")]
    [Space, Range(1, 10)]
    public float rotationXSpeed;
    [Space, Range(1, 10)]
    public float rotationYSpeed;

    [Header("Player Movement")]
    public float playerAcceleration = 5f;
    public float playerJumpForce = 5f;
    public float brakingAmplitude = 10f;
    public float StopTime = 3f;
}
