using UnityEngine;

public class PlayerHealth : DamageDealer, IDamageable
{
    public int Health { get; private set; }
    public int MaxHealth { get; set; }
    
    public void DealDamage(int damageToDeal)
    {
        Health -= damageToDeal;
    }
}
