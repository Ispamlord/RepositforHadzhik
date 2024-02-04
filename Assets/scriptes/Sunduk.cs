using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sunduk : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision != null && collision.gameObject.name == "Player")
        {
            Inventory inventory = collision.gameObject.GetComponent<Inventory>();
            if (inventory != null)
            {
                open(inventory);
            }
        }   
    }
    public void open(Inventory inv)
    {
        inv.Healka++;
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
