using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTraectoriya : MonoBehaviour
{
    public Transform target; // ѕерсонаж, на которого будет направлено оружие

    //private void OnTriggerStay2D(Collider2D collision)
    //{
    //    if (target != null && collision.name == target.name)
    //    {
    //        Target();
    //    }
    //}
    //private void Target()
    //{
    //        Vector3 targetDirection = target.position - transform.position;
    //        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90;
    //        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    //}
    void Update()
    {
        if (target != null)
        {
            Vector3 targetDirection = target.position - transform.position;
            float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}
