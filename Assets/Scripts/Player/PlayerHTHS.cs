using System;
using UnityEngine;

public class PlayerHTHS : MonoBehaviour
{
    [SerializeField] private Stat health = new Stat();
    [SerializeField] private ETeam team = ETeam.FIRST;

    public Stat Health => health;
    public ETeam Team => team;

    private void Update()
    {
        health.Regen();
    }
}
