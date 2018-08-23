using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mox_Jet : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=33
            *  
            *  {T}: Add {B} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Jet() : base()
        {
            MultiverseId = 33;
            Name = "Mox Jet";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mox Jet");
        }
        public Mox_Jet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
