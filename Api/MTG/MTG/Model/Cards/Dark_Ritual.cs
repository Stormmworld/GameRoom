using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Dark_Ritual : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=54
            *  
            *  Add {B}{B}{B} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Dark_Ritual() : base()
        {
            MultiverseId = 54;
            Name = "Dark Ritual";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Dark Ritual");
        }
        public Dark_Ritual(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
