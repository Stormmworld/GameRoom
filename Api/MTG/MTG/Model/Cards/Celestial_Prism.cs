using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Celestial_Prism : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=5
            *  
            *  {2}, {T}: Add one mana of any color to your mana pool.
            *  
            * Rulings

            *  
            */
        public Celestial_Prism() : base()
        {
            MultiverseId = 5;
            Name = "Celestial Prism";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Celestial Prism");
        }
        public Celestial_Prism(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
