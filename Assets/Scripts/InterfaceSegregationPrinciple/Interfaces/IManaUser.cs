public interface IManaUser
{
    int Mana { get; }
    int MaxMana { get; }
    
    void SpendMana(int manaToSpend);
}