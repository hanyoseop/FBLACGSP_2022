using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    public GameObject prefab, prefab2;
    
    public float spawnRate;

    // Spawn obstacles based on the spawn rate
    void Start() {
        InvokeRepeating("SpawnObstacle", spawnRate, spawnRate);
    }
    public void SpawnObstacle() {
        Instantiate(prefab);
        Instantiate(prefab2);
    }
}
