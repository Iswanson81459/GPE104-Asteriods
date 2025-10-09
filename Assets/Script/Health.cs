using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        currentHealth = currentHealth - amount;

        if (!isAlive())
        {
            currentHealth = 0;
            Die();
        }
    }

    public void Heal (float amount)
    {
        currentHealth = currentHealth + amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void Die()
    {
        // TODO: handle Deah in the health componet
        Death death = GetComponent<Death>();
        // if death Component exists
        if (death != null)
        {
            death.Die();
        }
    }

    public bool isAlive()
    {
        if(currentHealth > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
