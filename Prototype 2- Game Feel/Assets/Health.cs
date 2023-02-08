using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth, respawnTimer;
    [SerializeField]
    private int currentHealth;
    public GameObject smallEffect;
    public GameObject mediumEffect;
    public GameObject largeEffect;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        if (damage > 0 && damage < 15) {
            Instantiate(smallEffect, transform.position, Quaternion.identity);
        } else {
            Instantiate(mediumEffect, transform.position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        if (currentHealth <= 0f) {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            gameObject.GetComponent<Collider2D>().enabled = false;
            Instantiate(largeEffect, transform.position, Quaternion.identity);
            currentHealth = 100;
            Invoke("Respawn", respawnTimer);
        }

        if (transform.position.y < -10f || transform.position.y > 5f || Mathf.Abs(transform.position.x) > 15f) {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(0, 0, 0);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        gameObject.GetComponent<Collider2D>().enabled = true;
        if (currentHealth <= 0) {
            currentHealth = maxHealth;
        }
    }
}