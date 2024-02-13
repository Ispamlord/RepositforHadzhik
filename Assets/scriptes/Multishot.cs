using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multishot : MonoBehaviour
{
    public float arrowForce = 10f;
    public Transform firePoint;
    public GameObject arrowPrefab;
    public float cooldownTime = 1f;
    private bool isCooldown = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&& !isCooldown)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        isCooldown = true;
        Invoke("ResetCooldown", cooldownTime);

        for (float angle = 0; angle < 360; angle += 45)
        {
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, Quaternion.Euler(0, 0, angle));

            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
            Character character = arrow.GetComponent<Character>();
            character.owner = this.gameObject;
            Vector2 shootDirection = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

            rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
        }
    }

    void ResetCooldown()
    {
        // ���������� �����������
        isCooldown = false;
    }
}
