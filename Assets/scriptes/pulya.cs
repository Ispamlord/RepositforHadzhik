using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulya : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Character character = this.gameObject.GetComponent<Character>();
        if (!collision.isTrigger && collision.gameObject != character.owner )
        {
            Destroy(gameObject);
        }
    }
}