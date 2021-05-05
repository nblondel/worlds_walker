using System;
using UnityEngine;

public class InputsEventManager : MonoBehaviour {
    public delegate void BasicInput();
    public delegate void MovementInput(Vector3 movement, Vector3 rotation);

    public static event MovementInput OnMovementKeyPressed;
    public static event BasicInput OnJumpKeyPressed;
    public static event BasicInput OnJumpKeyReleased;

    public string inputMoveFront;
    public string inputMoveBack;
    public string inputMoveLeft;
    public string inputMoveRight;
    public string inputRotateLeft;
    public string inputRotateRight;

    private PlayerControls _playerControls;
    private Vector3 _movement;
    private Vector3 _rotation;

    public Vector2 _movementForwardInput;
    public Vector2 _movementRotateInput;

    private void OnEnable()
    {
        if(null == _playerControls)
        {
            _playerControls = new PlayerControls();
            _playerControls.Playermovement.Move.performed += i => _movementForwardInput = i.ReadValue<Vector2>();
            _playerControls.Playermovement.Rotate.performed += i => _movementRotateInput = i.ReadValue<Vector2>();
            _playerControls.Playermovement.Jump.started += ctx => OnJumpKeyPressed?.Invoke();
            _playerControls.Playermovement.Jump.canceled += ctx => OnJumpKeyReleased?.Invoke();
        }
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    // Update is called once per frame
    public void Update()
    {
        _movement.x = _movementForwardInput.y;
        _movement.z = _movementForwardInput.x;
        _rotation.y = _movementRotateInput.x;
        _rotation.z = _movementRotateInput.y;

        OnMovementKeyPressed?.Invoke(_movement, _rotation);
    }
}