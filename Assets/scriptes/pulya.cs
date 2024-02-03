using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulya : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Player" && !collision.isTrigger )
        {
            Destroy(gameObject);
        }
    }
}

