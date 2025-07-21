using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int maxHealth;
    public int currentHealth;

    public int GetHealth
    {
        get { return health; }
        set 
        { 
            health = value;
            if (health <= 0) 
            { 
                // kiem tra dieu kien thang thua
                // neu la Castle thi Thua
                // neu la Enemy thi check tiep xem da het Enemy chua, neu het roi thi Thang
            }
        }
    }

    public void Increase(int amount)
    {
        currentHealth += amount;
    }    
    public void Decrease(int amount)
    {
        currentHealth -= amount;
    }

}
