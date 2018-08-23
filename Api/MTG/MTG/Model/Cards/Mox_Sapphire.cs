using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mox_Sapphire : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=36
            *  
            *  {T}: Add {U} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Sapphire() : base()
        {
            MultiverseId = 36;
            Name = "Mox Sapphire";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mox Sapphire");
        }
        public Mox_Sapphire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
