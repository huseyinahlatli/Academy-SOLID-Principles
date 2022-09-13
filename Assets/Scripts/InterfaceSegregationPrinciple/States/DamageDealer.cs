using UnityEngine;

public class DamageDealer
{
    public void DamageTarget(Transform target, int damageToDeal)
    {
        var damageable = target.GetComponent<IDamageable>();

        if (damageable != null)
        {
            damageable.DealDamage(damageToDeal);
            Debug.Log(damageable.Health);
        }
    }
}
