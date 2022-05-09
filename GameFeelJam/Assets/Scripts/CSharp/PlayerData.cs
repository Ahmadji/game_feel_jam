using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player/PlayerData")]
public class PlayerData : ScriptableObject
{
    [Header("Player Settings")]
    [Space, Range(1, 10)]
    public float rotationXSpeed;
    [Space, Range(1, 10)]
    public float rotationYSpeed;
}
