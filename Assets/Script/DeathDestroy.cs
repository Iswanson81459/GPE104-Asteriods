using UnityEngine;

public class DeathDestroy : Death
{
    public bool givePoints;

    public int scoreAmount;
    public override void Die()
    {
        if (givePoints)
        {
            Debug.Log("should give points");
            GameManager.instance.UpdateScore(scoreAmount);
        }

        Destroy(gameObject);
    }

     
}
