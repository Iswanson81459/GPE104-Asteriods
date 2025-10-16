using UnityEngine;

public class DamageOnOverlap : MonoBehaviour
{
    public bool instantKill;
    public float damageDone;
    public bool destroyOnDamage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // GameManager.instance.damageZone.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnDestroy()
    {
        // GameManager.instance.damageZone.Remove(this);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(!instantKill)
        {
            Debug.Log("hit!" + other.gameObject.name);

            Health otherHealth = other.gameObject.GetComponent<Health>();
            if (otherHealth != null)
            {
                otherHealth.TakeDamage(damageDone);
            }
        }
        else
        {
            Death otherObject = other.GetComponent<Death>();
            if(otherObject != null)
            {
                otherObject.Die();
            }
            
        }
        if(destroyOnDamage)
        {
            GameObject.Destroy(gameObject);
        }
        
    }
}
