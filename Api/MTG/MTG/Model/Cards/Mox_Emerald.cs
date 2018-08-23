using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mox_Emerald : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=32
            *  
            *  {T}: Add {G} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Emerald() : base()
        {
            MultiverseId = 32;
            Name = "Mox Emerald";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mox Emerald");
        }
        public Mox_Emerald(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
