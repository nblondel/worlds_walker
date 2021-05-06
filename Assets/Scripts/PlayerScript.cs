using System;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private CapsuleCollider _playerCollider;
    private Animator _animator;

    private Vector3 _movement;
    private Vector3 _rotation;

    [Header("Ground")]
    public LayerMask groundLayer;

    [Header("Movements")]
    public float acceleration = 15.0f;
    public float turnSpeed = 110.0f;
    public Vector3 maxSpeed = new Vector3(13f, 15f, 10f);
    public float jumpDelay = 0.25f;

    [Header("Gravity")]
    public float globalGravity = 9.81f;
    public float linearDrag = 8.5f;
    public float fallMultiplier = 5f;

    // Compute movement variables
    private float _forwardSpeed = 0f;
    private float _sideSpeed = 0f;
    private float _highestSpeed = 0f;
    private Vector2 _currentSpeed = Vector2.zero;
    private Vector3 _newPosition;
    private float _jumpTimer;

    private bool _isGrounded;
    private bool _jumpAsked;
    private bool _stopJumpAsked;

    private void OnEnable()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _animator = gameObject.GetComponent<Animator>();
        _playerCollider = gameObject.GetComponent<CapsuleCollider>();

        _rigidbody.useGravity = false;
        InputsEventManager.OnMovementKeyPressed += MoveInputPressed;
        InputsEventManager.OnJumpKeyPressed += JumpInputPressed;
        InputsEventManager.OnJumpKeyReleased += JumpInputReleased;
    }

    private void OnDisable()
    {
        InputsEventManager.OnMovementKeyPressed -= MoveInputPressed;
        InputsEventManager.OnJumpKeyPressed -= JumpInputPressed;
        InputsEventManager.OnJumpKeyReleased -= JumpInputReleased;
    }
 
    bool IsGrounded()
    {
        return Physics.CheckCapsule(_playerCollider.bounds.center, 
                                    new Vector3(_playerCollider.bounds.center.x, 
                                                _playerCollider.bounds.min.y - 0.5f, 
                                                _playerCollider.bounds.center.z), 0.5f,
                                    groundLayer.value);
    }

    // ===================
    //       UPDATE
    // ===================
   
    public void Update ()
    {
        CheckJump();
        Animate();
    }

    private void CheckJump()
    {
        if (_jumpAsked)
        {
            _jumpTimer = Time.fixedTime + jumpDelay;
            _jumpAsked = false;
        }
    }

    // ===================
    //    FIXED UPDATE
    // ===================

    public void FixedUpdate()
    {
        _isGrounded = IsGrounded();
        Move();
        Jump();
        ModifyPhysics();
    }

    private void Move()
    {
        // Acceleration
        _forwardSpeed += (Mathf.Abs(_movement.x) * acceleration) * Time.fixedDeltaTime;
        _forwardSpeed = Mathf.Clamp(_forwardSpeed, -maxSpeed.x, maxSpeed.x);
        _sideSpeed += (Mathf.Abs(_movement.z) * acceleration) * Time.fixedDeltaTime;
        _sideSpeed = Mathf.Clamp(_sideSpeed, -maxSpeed.z, maxSpeed.z);

        _highestSpeed = Mathf.Max(_forwardSpeed, _sideSpeed);
        _currentSpeed.x = _highestSpeed * _movement.x;
        _currentSpeed.y = _highestSpeed * _movement.z;

        // Rotate
        _rigidbody.MoveRotation(_rigidbody.rotation * Quaternion.Euler(new Vector2(0, _rotation.y * turnSpeed * Time.fixedDeltaTime)));
        // Move
        _newPosition = (transform.forward * _currentSpeed.x) + (transform.right * _currentSpeed.y);
        _rigidbody.MovePosition(_rigidbody.position + _newPosition * Time.fixedDeltaTime);

        // Deceleration (instant)
        if (_movement.x == 0)
        {
            _forwardSpeed = 0;
        }
        if (_movement.z == 0)
        {
            _sideSpeed = 0;
        }
    }

    private void Jump()
    {
        if (_jumpTimer > Time.fixedTime && _isGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 0);
            _rigidbody.AddForce(transform.up * maxSpeed.y, ForceMode.Impulse);
            _jumpTimer = 0;
        }
    }

    private void ModifyPhysics()
    {
        if (_isGrounded)
        { 
            // On ground
            _rigidbody.drag = 0;
            _rigidbody.AddForce(new Vector3(0, -1.0f, 0) * _rigidbody.mass * globalGravity, ForceMode.Force);
        }
        else
        { 
            // In the air
            _rigidbody.AddForce(new Vector3(0, -1.0f, 0) * _rigidbody.mass * globalGravity, ForceMode.Acceleration);
            _rigidbody.drag = linearDrag;

            if (_rigidbody.velocity.y < 0)
            { 
                // Falling
                _rigidbody.AddForce(new Vector3(0, -1.0f, 0) * _rigidbody.mass * globalGravity * fallMultiplier);
            }
            else if (_rigidbody.velocity.y > 0 && _stopJumpAsked)
            { 
                // Hang time
                _rigidbody.AddForce(new Vector3(0, -1.0f, 0) * _rigidbody.mass * globalGravity * (fallMultiplier / 2));
            }
        }
    }

    private void Animate()
    {
        if (_forwardSpeed >= 0.1f)
        {
            _animator.SetInteger("speed_forward", 1);
        }
        else if (_forwardSpeed <= -0.1f)
        {
            _animator.SetInteger("speed_forward", -1);
        }
        else
        {
            _animator.SetInteger("speed_forward", 0);
        }

        if (_sideSpeed >= 0.1f)
        {
            _animator.SetInteger("speed_side", 1);
        }
        else if (_sideSpeed <= -0.1f)
        {
            _animator.SetInteger("speed_side", -1);
        }
        else
        {
            _animator.SetInteger("speed_side", 0);
        }
    }

    // ===================
    //       INPUTS
    // ===================

    private void MoveInputPressed(Vector3 movement, Vector3 rotation)
    {
        _movement = movement;
        _rotation = rotation;
    }

    public void JumpInputPressed()
    {
        _jumpAsked = true;
        _stopJumpAsked = false;
    }

    private void JumpInputReleased()
    {
        _stopJumpAsked = true;
    }
}
