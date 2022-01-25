using UnityEngine;

public class ObstacleSpawning : MonoBehaviour
{
    public GameObject logPrefab;
    
    public float spwanRate;

    void Start() {
        InvokeRepeating("SpawnLog", spwanRate, spwanRate);
    }
    public void SpawnLog() {
        Instantiate(logPrefab);
    }
}
