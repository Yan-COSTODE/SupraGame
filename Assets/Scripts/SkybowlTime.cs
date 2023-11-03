using System;
using UnityEngine;

public class SkybowlTime : MonoBehaviour
{
    [SerializeField] private Vector2 fSpeed;
    [SerializeField] private Material material;

    public void Update() => material.mainTextureOffset += fSpeed * Time.deltaTime;

    private void OnDestroy() => material.mainTextureOffset = new Vector2(0.1f, 0.0f);
}
