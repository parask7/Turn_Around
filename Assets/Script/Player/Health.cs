using UnityEngine;
using UnityEngine.InputSystem;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    private int damageAmount = 20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
        if (Keyboard.current.kKey.wasPressedThisFrame)
        {
            DamageTaken();
        }


    }
    void Die()
    {
        Destroy(this.gameObject);
    }

    void DamageTaken()
    {
        // damage logic for testing
        currentHealth -= damageAmount;
        Debug.Log("Player Health: " + currentHealth);


        //change this logic to take damage from enemies or hazards 
    }
}
