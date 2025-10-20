using UnityEngine;

public class ShooterBullet : MonoBehaviour
{
    public GameObject bulletToShoot;
    public Transform startPostition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Fire()
    {
        // Generate the bullet projectile at a defined postition and with the rotation of the parent
        Instantiate(bulletToShoot, startPostition.position, transform.rotation);
    }
}
