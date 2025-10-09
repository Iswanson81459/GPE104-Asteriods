using UnityEngine;

public class DeathRecenter : Death
{
    public override void Die()
    {
        // Move the object back to 0,0,0
        transform.position = Vector3.zero;

        // also o the Die() from the parent (base) class
        base.Die();
    }
}
