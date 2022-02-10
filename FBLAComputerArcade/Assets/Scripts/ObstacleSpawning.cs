using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    public GameObject prefab, prefab2;
    
    public float spwanRate;

    void Start() {
        InvokeRepeating("SpawnObstacle", spwanRate, spwanRate);
    }
    public void SpawnObstacle() {
        Instantiate(prefab);
        Instantiate(prefab2);
    }
}
