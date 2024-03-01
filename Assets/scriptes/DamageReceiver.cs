using scriptes.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public int health = 100;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GetComponent<DamageReceiver>().enabled = false;
        if (gameObject.name == "Player")
        {
            GetComponent<Player>().enabled = false;
            Sceneswit sceneswit = new Sceneswit();
            sceneswit.sceneId = 0;
            sceneswit.GoToSampleScene();
            //Destroy(FindAnyObjectByType(GameObject.Find(Enemys)));
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
}
