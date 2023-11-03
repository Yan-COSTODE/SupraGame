using UnityEngine;
using UnityEngine.Serialization;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [FormerlySerializedAs("fDelay")] [SerializeField] private float fDampTime = 0.1f;
    private static readonly int Vertical = Animator.StringToHash("Vertical");
    private static readonly int Horizontal = Animator.StringToHash("Horizontal");

    public void SetVertical(float _vertical) => animator.SetFloat(Vertical, _vertical, fDampTime, Time.deltaTime);

    public void SetHorizontal(float _horizontal) => animator.SetFloat(Horizontal, _horizontal, fDampTime, Time.deltaTime);
}
