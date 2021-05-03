using UnityEngine;

public class InputsEventManager : MonoBehaviour {
    public delegate void BasicInput();
    public delegate void MovementInput(float forward, float side, float rotation);
    public static event MovementInput OnMovementKeyPressed;

    private PlayerControls _playerControls;

    public string inputMoveFront;
    public string inputMoveBack;
    public string inputMoveLeft;
    public string inputMoveRight;
    public string inputRotateLeft;
    public string inputRotateRight;

    private float _forwardMovement;
    private float _sideMovement;
    private float _rotationMovement;

    public Vector2 _movementForwardInput;
    public Vector2 _movementRotateInput;

    private void OnEnable()
    {
        if(null == _playerControls)
        {
            _playerControls = new PlayerControls();
            _playerControls.Playermovement.Move.performed += i => _movementForwardInput = i.ReadValue<Vector2>();
            _playerControls.Playermovement.Rotate.performed += i => _movementRotateInput = i.ReadValue<Vector2>();
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
        _forwardMovement = _movementForwardInput.y;
        _sideMovement = _movementForwardInput.x;
        _rotationMovement = _movementRotateInput.x;

        OnMovementKeyPressed?.Invoke(_forwardMovement, _sideMovement, _rotationMovement);
    }

    public static bool IsJumpButtonHeld() {
        return Input.GetButton("Jump");
    }
}