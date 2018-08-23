using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mana_Vault : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=30
            *  
            *  Mana Vault doesn't untap during your untap step.
At the beginning of your upkeep, you may pay {4}. If you do, untap Mana Vault.
At the beginning of your draw step, if Mana Vault is tapped, it deals 1 damage to you.
{T}: Add {C}{C}{C} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mana_Vault() : base()
        {
            MultiverseId = 30;
            Name = "Mana Vault";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mana Vault");
        }
        public Mana_Vault(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
