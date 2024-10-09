using UnityEngine;

public class HomeworkTwo : MonoBehaviour
{

    public int health = 10;
    public float baseDamage;
    public float multiplier;
    public bool isDead;
    public string damage;
    

    public void DamageCount()
    {
        damage = (baseDamage * multiplier).ToString();
        
        Debug.Log($"Player's health is {health}");
        Debug.Log($"Done damage {damage}");
        
        if (int.Parse(damage) > health)
        {
            isDead = true;
            Debug.Log("Player gained new level");
        }
        else
        {
            isDead = false;
            Debug.Log("Player doesnt gain new level");
        }
        
    }
    
    void Start()
    {
        DamageCount();
    }

    void OnValidate()
    {
        DamageCount();
    }
}
