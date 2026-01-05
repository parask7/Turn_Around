using UnityEngine;
using UnityEngine.InputSystem;

public class ThirdPersonCamera : MonoBehaviour
{
    [Header("References")]
    public Transform player;        // Player body
    public Transform cameraPivot;   // Empty object on player (chest/shoulder height)

    [Header("Camera Settings")]
    public float mouseSensitivity = 150f;
    public float distance = 4f;
    public float minY = -30f;
    public float maxY = 60f;

    private PlayerInput playerInput;
    private InputAction lookAction;

    private float yaw;
    private float pitch;

    void Awake()
    {
        playerInput = GetComponentInParent<PlayerInput>();
        lookAction = playerInput.actions.FindAction("Look");
    }

    void OnEnable()
    {
        lookAction?.Enable();
    }

    void OnDisable()
    {
        lookAction?.Disable();
    }

    void LateUpdate()
    {
        LookAround();
        UpdateCameraPosition();
    }

    void LookAround()
    {
        Vector2 lookInput = lookAction.ReadValue<Vector2>();

        yaw += lookInput.x * mouseSensitivity * Time.deltaTime;
        pitch -= lookInput.y * mouseSensitivity * Time.deltaTime;
        pitch = Mathf.Clamp(pitch, minY, maxY);
    }

    void UpdateCameraPosition()
    {
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);

        Vector3 direction = rotation * Vector3.back;
        transform.position = cameraPivot.position + direction * distance;

        transform.LookAt(cameraPivot.position);
    }
}
