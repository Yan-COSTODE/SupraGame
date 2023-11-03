using System;
using UnityEngine;

[Serializable]
public struct Stat
{
    [SerializeField] private float fCurrent;
    [SerializeField] private float fMin;
    [SerializeField] private float fMax;
    [SerializeField] private float fRegenRate;
    [SerializeField] private bool bCanRegen;

    public float Percent => fCurrent / fMax;
    public float Current => fCurrent;
    
    public Stat(float _fCurrent, float _fMin, float _fMax, float _fRegenRate, bool _bCanRegen)
    {
        fCurrent = _fCurrent;
        fMin = _fMin;
        fMax = _fMin;
        fRegenRate = _fRegenRate;
        bCanRegen = _bCanRegen;
    }
    
    public void SetRegen(bool _status) => bCanRegen = _status;
    
    public void Remove(float _amount) => fCurrent = fCurrent - _amount < fMin ? fMin : fCurrent - _amount;
    
    public void Add(float _amount) => fCurrent = fCurrent + _amount > fMax ? fMax : fCurrent + _amount;
    
    public void Regen()
    {
        if (!bCanRegen)
            return;
        Add(fRegenRate * Time.deltaTime);
    }
}
