using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Fireball"))
        {
            enemyHealth -= 10;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
