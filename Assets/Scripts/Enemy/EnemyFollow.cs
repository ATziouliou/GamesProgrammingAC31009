using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{

    public NavMeshAgent enemy;
    public GameObject player;

    void Start()
    {
        // Find the player object by tag
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (enemy != null)
        {
            // Set enemy destination to player's location
            enemy.SetDestination(player.transform.position);
        }
    }
}
