using UnityEngine;


public class HealthPack : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int healAmount = 10; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerHealth.health != 100)
            {
                playerHealth.health += healAmount;
                Destroy(gameObject);
            }
        }
    }
}
