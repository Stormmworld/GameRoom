using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mox_Ruby : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=35
            *  
            *  {T}: Add {R} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Ruby() : base()
        {
            MultiverseId = 35;
            Name = "Mox Ruby";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mox Ruby");
        }
        public Mox_Ruby(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
