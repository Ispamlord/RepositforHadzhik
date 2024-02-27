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
            if (target == null)
            {
                Destroy(gameObject);
            }

            if (CD) return;
            Fire();
            CD = true;
            Invoke(nameof(ResetMagic), couldown);
        }
    }
    private void Update()
    {
    }

    private void Fire()
    {
         Vector2 direction = target.position - transform.position;
         direction.Normalize();
         shot = direction;
         shoot.Shoot(shot);
    }
    public void ResetMagic()
    {
        CD = false;
    }
}
