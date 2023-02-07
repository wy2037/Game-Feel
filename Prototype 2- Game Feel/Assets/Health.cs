using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth, respawnTimer;
    [SerializeField]
    private int currentHealth;

    void Start()
    {
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

    void Respawn()
    {
        Debug.Log("test");
    }
}