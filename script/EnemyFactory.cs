using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    public Enemy SpawnEnemy(GameObject enemyPrefab, Vector3 position, Quaternion rotation)
    {
        GameObject enemyGo = Instantiate(enemyPrefab, position, rotation);
        Enemy enemy = enemyGo.GetComponent<Enemy>();
        return enemy;
    }
}
