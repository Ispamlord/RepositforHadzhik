using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunduk : MonoBehaviour
{
    private bool gem = true;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision == null || collision.gameObject.name != "Player") return;
        Inventory inventory = collision.gameObject.GetComponent<Inventory>();
        if (inventory != null)
        {
            Open(inventory);
        }
    }
    private void Open(Inventory inv)
    {
        inv.Healka++;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
