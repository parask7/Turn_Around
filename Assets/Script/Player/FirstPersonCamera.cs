using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    private PlayerInput playerInput;
    private InputAction lookAction;
    private Vector2 lookInput;
    private float xRotation = 0f;
    
    void Start()
    {
        playerInput = GetComponentInParent<PlayerInput>();
        lookAction = playerInput.actions.FindAction("Look");
    }

    void OnEnable()
    {
        if(lookAction != null)
            lookAction.Enable();
    }
    void OnDisable()
    {
        if(lookAction != null)
            lookAction.Disable();
    }

    void Update()
    {
        lookAround();
    }
    void lookAround()
    {
        lookInput = lookAction.ReadValue<Vector2>();

        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
