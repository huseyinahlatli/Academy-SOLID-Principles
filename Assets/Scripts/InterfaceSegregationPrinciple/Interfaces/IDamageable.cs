public interface IDamageable
{
    int Health { get; }
    int MaxHealth { get; set; }

    void DealDamage(int damageToDeal);
}
