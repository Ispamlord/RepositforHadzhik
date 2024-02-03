using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shoting : MonoBehaviour
{
    //public Transform firePoint;  // �������, ������ ����� �������� ������
    //public GameObject arrowPrefab;  // ������ ������
    //public float arrowForce = 20f;  // ���� ��������

    //// ������� ��� ��������
    //void Shoot()
    //{
    //    // �������� ������� ���� � ������� �����������
    //    Vector3 mousePosition = Input.mousePosition;
    //    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    //    // ������� ��������� ������ �� �������
    //    GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

    //    // �������� ��������� Rigidbody2D ������
    //    Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

    //    // ��������� ����������� �� firePoint � ������� ����
    //    Vector2 shootDirection = (mousePosition - firePoint.position).normalized;

    //    // ������� ������ ���� � ��������� �����������
    //    rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
    //}
    public Transform firePoint;
    public GameObject arrowPrefab;
    public float arrowForce = 20f;

    public void Shoot(Vector2 shootDirection)
    {
        // ������� ��������� ������ �� �������
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

        // �������� ��������� Rigidbody2D ������
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        // ������� ������ ���� � ��������� �����������
        rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
    }

}
