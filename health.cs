using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100;     // Maximum health of the player
    public int currentHealth;       // Current health of the player

    void Start()
    {
        // Initialize current health to max health at the start
        currentHealth = maxHealth;
    }

    // Method to increase health
    public void Heal(int healAmount)
    {
        currentHealth += healAmount;

        // Clamp health so it doesn't exceed maxHealth
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log("Player Health after healing: " + currentHealth);
    }

    // Optional method to take damage (in case you want to decrease health as well)
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        // Clamp health to ensure it doesn’t go below 0
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        Debug.Log("Player Health after taking damage: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player is dead.");
        // Add death animations, respawn logic, or game over here
    }
}
