using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    private float lastSpawnTime;
    public float spawnRadius = 2.0f;
    public float spawnInterval = 1.0f;
    public GameObject enemyPrefab;
    public GameObject player;
    void Update()
    {
        if (Time.time - lastSpawnTime > spawnInterval)
        {
            Spawn();
            lastSpawnTime = Time.time;
        }
    }

    private void Spawn()
    {
        var enemy = Instantiate(enemyPrefab);
        var theta = Random.Range(0, 2 * Mathf.PI);
        var spawnPos = new Vector3(Mathf.Cos(theta) * spawnRadius, 0, Mathf.Sin(theta) * spawnRadius);
        enemy.transform.position = player.transform.position + spawnPos;
    }
}
