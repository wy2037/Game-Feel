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
        if (currentHealth <= 0f) {
            Invoke("Respawn", respawnTimer);
        }

        if (transform.position.y < -10f || transform.position.y > 5f || Mathf.Abs(transform.position.x) > 15f) {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(0, 0, 0);
        if (currentHealth <= 0f) {
            currentHealth = maxHealth;
        }
    }
}