using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField]
    private int maxHealth;
    [SerializeField]
    private int currentHealth;
    public GameObject smallEffect;
    public GameObject mediumEffect;
    public GameObject largeEffect;
    public GameObject[] splash;
    public bool splashToggle = true;
    public int respawnTimer;
    private int rand;
    public Shake camera;

    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private AudioClip[] clips;

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
        if (currentHealth > 0) {
            source.PlayOneShot(clips[0]);
        }
    }

    void FixedUpdate()
    {
        if (currentHealth <= 0f) {
            source.PlayOneShot(clips[1]);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
            gameObject.GetComponent<Collider2D>().enabled = false;
            camera.start = true;
            Instantiate(largeEffect, transform.position, Quaternion.identity);
            if (splashToggle == true) {
                rand = Random.Range(1, 3);
                Instantiate(splash[rand], transform.position, Quaternion.identity);
            }
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