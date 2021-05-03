using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private void OnEnable()
    {
        InputsEventManager.OnMovementKeyPressed += MoveInputPressed;
    }

    private void OnDisable()
    {
        InputsEventManager.OnMovementKeyPressed -= MoveInputPressed;
    }
    private void MoveInputPressed(float forwardMovement, float sideMovement, float rotationMovement)
    {
        //_forwardMovement = forwardMovement;
        //_sideMovement = sideMovement;
        //_rotationMovement = rotationMovement;
    }
}
