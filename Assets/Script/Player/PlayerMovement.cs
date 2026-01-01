using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -25f;   // 🔥 stronger gravity
    public float jumpHeight = 1.5f;

    private CharacterController controller;
    private PlayerInput playerInput;
    private InputAction moveAction;
    private InputAction jumpAction;

    private Vector3 velocity;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();

        moveAction = playerInput.actions.FindAction("Player/Move");
        jumpAction = playerInput.actions.FindAction("Player/Jump");
    }

    void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }

    void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }

    void Update()
    {
        Vector2 input = moveAction.ReadValue<Vector2>();

        Vector3 move =
            transform.right * input.x +
            transform.forward * input.y;

        // ✅ stick to ground
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -5f;
        }

        // ✅ jump
        if (jumpAction.WasPressedThisFrame() && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        // ✅ gravity
        velocity.y += gravity * Time.deltaTime;

        // ✅ ONE Move call
        Vector3 finalMove = move * speed + velocity;
        controller.Move(finalMove * Time.deltaTime);
    }
}
