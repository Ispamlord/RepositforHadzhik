using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public Transform target;
    public Shoting shoot;
    public bool CD= false;
    public float couldown = 5f;
    private Vector2 shot;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == target.name)
        {
            shot = collision.transform.position;
        }
    }
    private void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
        }
        if (!CD)
        {
            fire();
            CD = true;
            Invoke("ResetMagic", couldown);
        }
    }
    public void fire()
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
