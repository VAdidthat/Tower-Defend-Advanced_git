using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int gold;
    public int GetGold
    {
        get { return gold; }
        set { gold = value; }
    }

    public void Increase(int amount)
    {
        gold += amount;
    }
    public void Decrease(int amount)
    {
        gold -= amount;
    }
}
