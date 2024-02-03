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
        // ѕолучаем позицию мыши в мировых координатах
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ¬ычисл€ем направление от оружи€ к позиции мыши
        lookDirection = (mousePosition - transform.position).normalized;

        // ¬ычисл€ем угол поворота в радианах
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        // ѕоворачиваем оружие в соответствии с углом
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
