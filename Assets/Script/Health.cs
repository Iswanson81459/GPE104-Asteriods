using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;

    public float maxHealth;

    public void TakeDamage(float amount)
    {

        currentHealth = currentHealth - amount;

        if (!IsAlive())
        {

            Die();

        }

    }

    public void Heal (float amount)
    {
        currentHealth = currentHealth + amount;
    }



    public void Die()

    {

        // TODO: Handle death in the health componen	 

    }


    public bool IsAlive()
    {

        if(currentHealth > 0)
    

            return true;


        else

            return false;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
