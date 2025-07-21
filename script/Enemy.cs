using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public Attack attack;
    public Health health;
    public Waypoints waypoints;
    public float moveSpeed;
    public int goldReward;

    public Vector3 Move()
    {
        //vi tri dua theo waypoint va moveSpeed
        return Vector3.one;
    }

    public void Attack()
    {
        //khi enemy di den last waypoint, tan cong va tru mau Castle theo Damage
    }

    public void OnDestroy()
    {
        Debug.Log("Enemy destroyed! +" + goldReward + " gold");
        // +gold vao inventory
        // check dieu kien thang
    }

}
