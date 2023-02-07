using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private float maxHealth, respawnTimer;
    private float currentHealth;

    void Start()
    {
        // Player starts at full health
        currentHealth = maxHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
    }

    void FixedUpdate()
    {
        //bar.UpdateHealthBar(maxHealth, currentHealth);
        if (currentHealth <= 0f) {
            Invoke("Respawn", respawnTimer);
        }
    }
}