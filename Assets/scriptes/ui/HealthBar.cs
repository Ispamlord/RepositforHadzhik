using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image healthBarImage;
    public DamageReceiver playerScript;
    private int maxHealth;

    private void Start()
    {
        // Initialize 
        healthBarImage = transform.Find("HealthBar").GetComponent<Image>();
        playerScript = FindObjectOfType<DamageReceiver>();
        maxHealth = playerScript.health;
    }

    private void Update()
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        // Ensure playerScript and healthBarImage are not null
        if (playerScript != null && healthBarImage != null)
        {
            // Calculate health percentage (0 to 1)
            float healthPercentage = playerScript.health / maxHealth;

            // Set health bar size based on percentage
            healthBarImage.fillAmount = healthPercentage;
        }
    }
}