using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shoting : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject arrowPrefab;
    public float arrowForce = 20f;
    public void Shoot(Vector2 shootDirection)
    {
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        Character character = arrow.GetComponent<Character>();
        character.owner = this.gameObject;
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * arrowForce, ForceMode2D.Impulse);
    }
}
