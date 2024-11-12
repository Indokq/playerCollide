using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    public int healAmount = 20; // Amount of health restored by the potion

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a HealthManager component (i.e., the player)
        HealthManager healthManager = other.GetComponent<HealthManager>();

        if (healthManager != null)
        {
            // Heal the player by the specified amount
            healthManager.Heal(healAmount);

            // Destroy the potion after it has been used
            Destroy(gameObject);
            Debug.Log("Health Potion used! Player's health increased by " + healAmount);
        }
    }
}
