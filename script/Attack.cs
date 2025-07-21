using UnityEngine;

public class Attack : MonoBehaviour
{
    public int damage;
    public GameObject attacker;
    public GameObject target;
    public void OnHitEffect()
    {
        // hieu ung don danh
    }
    public void AttackTarget(GameObject attacker, GameObject target)
    {
        this.attacker = attacker;
        this.target = target;
        // tan cong, them hieu ung don danh neu can
    }
}
