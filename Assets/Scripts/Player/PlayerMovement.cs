using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float fMoveSpeed = 1.0f;
    [SerializeField] private float fSpeedModifier = 2.0f;
    [SerializeField] private float fRotateSpeed = 1.0f;
    [SerializeField] private PlayerAnimation playerAnimation;
    private bool bIsSprinting;

    private float Speed => bIsSprinting ? fMoveSpeed * fSpeedModifier : fMoveSpeed;
    
    private void Update()
    {
        MoveForward(Input.GetAxis("Vertical"));
        MoveRight(Input.GetAxis("Horizontal"));
        Rotate(Input.GetAxis("Mouse X"));
        bIsSprinting = Input.GetKey(KeyCode.LeftShift);
    }

    private void Rotate(float _axis)
    {
        Transform _transform = transform;
        _transform.eulerAngles += _transform.up * (Time.deltaTime * _axis * fRotateSpeed); 
    }
    
    private void MoveForward(float _axis)
    { 
        Transform _transform = transform;
        playerAnimation.SetVertical(bIsSprinting ? _axis * 2 : _axis);
        if (_axis > 0)
            _transform.position += _transform.forward * (Time.deltaTime * _axis * Speed);
        else
            _transform.position += _transform.forward * (Time.deltaTime * _axis * fMoveSpeed);
    }
    
    private void MoveRight(float _axis)
    {
        Transform _transform = transform;
        playerAnimation.SetHorizontal(_axis);
        _transform.position += _transform.right * (Time.deltaTime * _axis * fMoveSpeed);
    }
}
