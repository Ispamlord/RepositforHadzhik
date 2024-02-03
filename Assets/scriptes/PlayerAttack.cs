using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Shoting shooter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �������� ������� ���� � ������� �����������
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // ��������� ����������� �� firePoint � ������� ����
            Vector2 shootDirection = (mousePosition - shooter.firePoint.position).normalized;

            // �������� �������� � ���������� Shooter
            shooter.Shoot(shootDirection);
        }
    }
}
