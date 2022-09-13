using UnityEngine;

public class ManaSpender
{
    public void CastSpell(Transform caster, int manaCost)
    {
        var manaUser = caster.GetComponent<IManaUser>();

        if (manaUser != null)
        {
            manaUser.SpendMana(manaCost);
            Debug.Log(manaUser.Mana);
        }
    }
}