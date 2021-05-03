using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private CapsuleCollider _playerCollider;
    private Animator _animator;
    private float _forwardMovement;
    private float _sideMovement;
    private float _rotationMovement;

    public float maxSpeed = 15.0f; // in meters per second
    public float maxAcceleration = 5.0f; // in meters/second/second
    public float acceleration = 5.0f; // in meters/second/second
    public float turnSpeed = 30.0f; // in degrees/second

    private float _forwardSpeed = 0.0f;    // in meters/second
    private float _sideSpeed = 0.0f;    // in meters/second
    private float _highestSpeed = 0.0f; // the current highest speed between forward and side

    public Vector3 jumpSpeed;
    
    private void OnEnable()
    {
        InputsEventManager.OnMovementKeyPressed += MoveInputPressed;
    }

    private void OnDisable()
    {
        InputsEventManager.OnMovementKeyPressed -= MoveInputPressed;
    }

    void Awake ()
    {
        _animator = gameObject.GetComponent<Animator>();
        _playerCollider = gameObject.GetComponent<CapsuleCollider>();
    }
 
    bool IsGrounded()
    {
        return Physics.CheckCapsule(_playerCollider.bounds.center, 
                                    new Vector3(_playerCollider.bounds.center.x, 
                                                _playerCollider.bounds.min.y - 0.1f, 
                                                _playerCollider.bounds.center.z), 0.08f);
    }
   
    public void Update ()
    {
        Move();
        Animate();

        /*if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Vector3 v = gameObject.GetComponent<Rigidbody>().velocity;
            v.y = jumpSpeed.y;
            gameObject.GetComponent<Rigidbody>().velocity = jumpSpeed;
        }*/
    }
    
    private void Move()
    {
        transform.Rotate(0, _rotationMovement * (turnSpeed * 2) * Time.deltaTime, 0);

        _forwardSpeed += (Mathf.Abs(_forwardMovement) * acceleration) * Time.deltaTime;
        _forwardSpeed = Mathf.Clamp(_forwardSpeed, -maxSpeed, maxSpeed);

        _sideSpeed += (Mathf.Abs(_sideMovement) * acceleration) * Time.deltaTime;
        _sideSpeed = Mathf.Clamp(_sideSpeed, -maxSpeed, maxSpeed);

        _highestSpeed = Mathf.Max(_forwardSpeed, _sideSpeed);
        transform.Translate(0, 0, _forwardMovement * _highestSpeed * Time.deltaTime);
        transform.Translate(_sideMovement * _highestSpeed * Time.deltaTime, 0, 0);

        if (0 == _forwardMovement)
        {
            _forwardSpeed = 0;
        }
        if (0 == _sideMovement)
        {
            _sideSpeed = 0;
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

    private void MoveInputPressed(float forwardMovement, float sideMovement, float rotationMovement)
    {
        _forwardMovement = forwardMovement;
        _sideMovement = sideMovement;
        _rotationMovement = rotationMovement;
    }
}
