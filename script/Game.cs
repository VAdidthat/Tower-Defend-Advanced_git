using UnityEngine;

public class Game : MonoBehaviour
{
    public bool isGameLose;
    public Level level;

    private void Start()
    {
        Debug.Log("Game Started");
        // khoi tao level, map scene, castleFactory, inventoryFactory, towerFactory, waypointFactory, enemyFactory, ...
    }
}
