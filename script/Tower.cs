using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject TowerPrefab;
    public Bullet bullet;
    public Attack attack;

    public void OnCollisionEnter(Collision enemy)
    {
        Debug.Log("enemy detected");
        //phat hien enemy, kich hoat tan cong
    }
}
