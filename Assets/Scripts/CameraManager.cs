using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraManager : MonoBehaviour
{
    public Transform target;

    [Header("Distance from target")]
    public float DistanceBehind;
    public float DistanceAbove;
    [Header("Idle reset time of the up/down rotation")]
    public float rotationResetTime;

    // Camera position computation
    private Vector3 lookpoint;
    private Vector3 bepoint;
    private Vector3 newBe;
    private Vector3 newLook;

    // Camera hook time (the greater the faster)
    const float snapBe = 5.0f;
    const float snapLook = 3.0f;

    // Rotation on X
    private Vector3 _inputRotation;
    private int _inputRotationNormalized;
    private float rotation_x;
    private float _maxRotationAngle = 25.0f;

    // Rotation idle mechanism
    private float _rotationIdleTimer;

    private void OnEnable()
    {
        InputsEventManager.OnMovementKeyPressed += MoveInputPressed;
    }

    private void OnDisable()
    {
        InputsEventManager.OnMovementKeyPressed -= MoveInputPressed;
    }

    private void Update()
    {
        UpdateTarget();
        FollowTarget();
        IdleRotation();
    }

    private void UpdateTarget()
    {
        if (!IsInputRotation())
        {
            rotation_x += _inputRotation.z * _maxRotationAngle * (snapLook * Time.deltaTime);
            rotation_x = Mathf.Clamp(rotation_x, -_maxRotationAngle, _maxRotationAngle);
        }

        target.localEulerAngles = new Vector3(-rotation_x, target.localEulerAngles.y, target.localEulerAngles.z);
    }

    private void FollowTarget()
    {
        newBe = target.position + (target.forward * DistanceBehind) + (Vector3.up * DistanceAbove);
        newLook = target.position;

        bepoint = Vector3.Lerp(bepoint, newBe, snapBe * Time.deltaTime);
        lookpoint = Vector3.Lerp(lookpoint, newLook, snapLook * Time.deltaTime);

        transform.position = bepoint;
        transform.LookAt(lookpoint);
    }

    private void IdleRotation()
    {
        // If there is no rotation, the camera will reset after an idle time
        if (IsInputRotation())
        {
            // No rotation
            if (_rotationIdleTimer == 0)
            {
                // Start Idle camera rotation timer
                _rotationIdleTimer = Time.time + rotationResetTime;
            }
            else
            {
                // Idle camera rotation timer is already started
                if (_rotationIdleTimer <= Time.time)
                {
                    // The timer has expired, reset the camera target
                    rotation_x = 0.0f;
                    _rotationIdleTimer = 0;
                }
            }
        }
        else
        {
            // Rotation running, reset the timer
            _rotationIdleTimer = 0;
        }
    }

    private void MoveInputPressed(Vector3 movement, Vector3 rotation)
    {
        _inputRotation = rotation;
    }

    private bool IsInputRotation()
    {
        // Prevent camera rotation from minor changes
        if (_inputRotation.z <= 0.30f && _inputRotation.z >= -0.30f)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
