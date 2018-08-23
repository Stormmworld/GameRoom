using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wheel_of_Fortune : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=231
            *  
            *  Each player discards his or her hand, then draws seven cards.
            *  
            * Rulings

            *  
            */
        public Wheel_of_Fortune() : base()
        {
            MultiverseId = 231;
            Name = "Wheel of Fortune";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Wheel of Fortune");
        }
        public Wheel_of_Fortune(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
