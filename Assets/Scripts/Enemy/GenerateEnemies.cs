using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateEnemies : MonoBehaviour
{

    public GameObject enemy1;
    public GameObject enemy2;
    public int xPos;
    public int zPos;
    public int enemyCount;
    private float spawnInterval = 5f;
    private float spawnIntervalRate = 0.1f;
    private float minSpawnInterval = 0.3f;

    public YouWon YouWonScreen;

    //Keep track of all enemies
    private List<GameObject> enemies = new List<GameObject>();

    private GameObject enemy1Instance;
    private GameObject enemy2Instance;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount <= 50)
        {

            // Set range of spawning enemies
            xPos = Random.Range(-49, 49);
            zPos = Random.Range(-49, 49);

            // Spawn enemies
            enemy1Instance = Instantiate(enemy1, new Vector3(xPos, 1, zPos), Quaternion.identity);
            enemy2Instance = Instantiate(enemy2, new Vector3(xPos, 1, zPos), Quaternion.identity);

            enemies.Add(enemy1Instance);
            enemies.Add(enemy2Instance);

            // Spawn timer
            yield return new WaitForSeconds(spawnInterval);
            enemyCount += 1;
            spawnInterval -= spawnIntervalRate;
            spawnInterval = Mathf.Max(spawnInterval, minSpawnInterval);
        }
    }

    // Check for all enemies killed
    private bool AllEnemiesKilled()
    {
        foreach (GameObject enemy in enemies)
        {
            if (enemy != null)
            {
                return false;
            }
        }
        return true;
    }

    void Update()
    {
       if (AllEnemiesKilled())
       {
            YouWonScreen.Setup();
       }
    }
}
