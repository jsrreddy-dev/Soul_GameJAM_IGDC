using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    // Player Movement Variables
    [Header("Player Movement")]
    [Tooltip("Speed of the player")]
    // Speed of the player
    [SerializeField] private float playerSpeed = 5.0f;

    // Vector2 to store the player movement input
    private Vector2 playerMoveInput;

    [SerializeField] private InputAction playerInputAction;

    private void Awake()
    {
        playerInputAction = GetComponent<PlayerInput>().actions["Move"];
    }



}
