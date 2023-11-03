using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField, Header("Offset")] private Vector3 lookOffset;
    [SerializeField] private Vector3 offset;
    [SerializeField, Header("Speed")] private float fLookSpeed = 10.0f;
    [SerializeField] private float fFollowSpeed = 10.0f;

    private void Awake()
    {
        SetRotation(999.0f);
        SetPosition(999.0f);
    }

    private void Update()
    {
        SetRotation(fLookSpeed);
        SetPosition(fFollowSpeed);
    }

    private void SetRotation(float _speed)
    {
        Vector3 _targetDir = (target.position + lookOffset) - transform.position;
        if (_targetDir == Vector3.zero)
            return;
        Quaternion _rotation = Quaternion.LookRotation(_targetDir);
        transform.rotation = Quaternion.Slerp(transform.rotation, _rotation, _speed * Time.deltaTime);
    }

    private void SetPosition(float _speed)
    {
        Vector3 _position = target.position + target.right * offset.x + target.up * offset.y + target.forward * offset.z;
        transform.position = Vector3.Slerp(transform.position, _position, _speed * Time.deltaTime);
    }
}
