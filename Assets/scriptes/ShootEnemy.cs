using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShootEnemy : MonoBehaviour
{
    public GameObject owner;
    public Transform target;
    public Shoting shoot;
    public bool CD = false;
    public float cooldown = 5f;
    
    private Vector2 shot;
    
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.name == target.name)
        {
            shot = collision.transform.position;
        }
    }
    private void Update()
    {
        if (!CD)
        {
            Fire();
            CD = true;
            Invoke("ResetMagic", cooldown);
        }
    }

    private void Fire()
    {
         Vector2 direction = target.position - transform.position;
         //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
         direction.Normalize();
         shot = direction;
         shoot.Shoot(shot);
    }
    public void ResetMagic()
    {
        CD = false;
    }
}
