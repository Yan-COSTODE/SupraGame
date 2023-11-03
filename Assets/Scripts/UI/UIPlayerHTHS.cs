using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayerHTHS : MonoBehaviour
{
    [SerializeField] private PlayerHTHS player;
    [SerializeField, Header("Team")] private GameObject hider;
    [SerializeField] private GameObject seeker;
    [SerializeField, Header("Health")] private Image healthBar;
    [SerializeField] private TMP_Text healthText;

    private void Start()
    {
        hider.SetActive(player.Team == ETeam.FIRST);
        seeker.SetActive(player.Team == ETeam.SECOND);
    }

    private void Update()
    {
        healthBar.fillAmount = player.Health.Percent;
        healthText.text = player.Health.Current.ToString("0.");
    }
}
