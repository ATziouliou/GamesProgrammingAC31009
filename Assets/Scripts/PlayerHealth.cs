using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public int maxhealth = 10;
    public int health;
    public Image healthBar;
    public GameOverScreen GameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        // Update health Bar
        healthBar.fillAmount = health / 10f;
        
        // When player dies
        if (health <= 0)
        {
            Destroy(gameObject);
            GameOverScreen.Setup();
        }
    }
}