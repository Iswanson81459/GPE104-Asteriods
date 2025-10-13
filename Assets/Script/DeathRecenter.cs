using UnityEngine;

public class DeathRecenter : Death
{
    public override void Die()
    {
        // Move the object back to 0,0,0
        transform.position = Vector3.zero;

        Debug.Log("Should of Recentered");

        // also o the Die() from the parent (base) class
        base.Die();
    }
}
