using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Orcish_Oriflamme : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=214
            *  
            *  Attacking creatures you control get +1/+0.
            *  
            * Rulings

            *  
            */
        public Orcish_Oriflamme() : base()
        {
            MultiverseId = 214;
            Name = "Orcish Oriflamme";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Orcish Oriflamme");
        }
        public Orcish_Oriflamme(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
