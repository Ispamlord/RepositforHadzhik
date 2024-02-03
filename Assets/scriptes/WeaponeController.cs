using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponeController : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 mousePosition;
    private Vector2 lookDirection;
    void Update()
    {
        // �������� ������� ���� � ������� �����������
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ��������� ����������� �� ������ � ������� ����
        lookDirection = (mousePosition - transform.position).normalized;

        // ��������� ���� �������� � ��������
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        // ������������ ������ � ������������ � �����
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
