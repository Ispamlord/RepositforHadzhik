using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private DamageReceiver damageReceiver;
    public HealthBar_2 health;
    private PlayerMovement playerMovement;
    private PlayerAttack playerAttack;
    private void Awake()
    {
        damageReceiver = GetComponent<DamageReceiver>();
        health.SetMaxHealth(damageReceiver.health);
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
    }
    private void FixedUpdate()
    {
        
        playerMovement.Move();
        health.SetHealth(damageReceiver.health);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAttack.Attack();
        }
    }
}
