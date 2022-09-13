public class PlayerMana : ManaSpender, IManaUser
{
    public int Mana { get; private set; }
    public int MaxMana { get; }
   
    public void SpendMana(int manaToSpend)
    {
        Mana -= manaToSpend;
    }
    
    public PlayerMana(int mana, int maxMana)
    {
        Mana = mana;
        MaxMana = maxMana;
    }
}