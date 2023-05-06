using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    public int damage = 1;


    // When enemy collides with the player
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.GetComponent<PlayerHealth>() != null)
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
        else
        {

        }
    }

    // Damage over time
    // Couldnt fix it in time
    private void OnTriggerStay(Collider collision)
    {
        if (collision.GetComponent<PlayerHealth>() != null)
        {
            //collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(1);

        }
        
    }
}
