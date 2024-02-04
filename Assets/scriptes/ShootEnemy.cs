using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootEnemy : MonoBehaviour
{
    public Transform target;
    public Shoting shoot;
    public bool CD= false;
    public float couldown = 5f;
    Vector2 shot;
    // Start is called before the first frame update
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == target.name)
        {
            //fire();
            shot = collision.transform.position;
            
        }
    }
    private void Update()
    {
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
         float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
         direction.Normalize();
         shot = direction;
         shoot.Shoot(shot);
    }
    public void ResetMagic()
    {
        CD = false;
    }
}
