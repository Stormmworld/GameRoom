using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Keldon_Warlord : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=208
            *  
            *  Keldon Warlord's power and toughness are each equal to the number of non-Wall creatures you control.
            *  
            * Rulings
		        2008-08-01: This is a Characteristic-Defining Ability. It checks the number of non-Wall creatures you control continuously, and applies in all zones. It is never "locked in".
            *  
            */
        public Keldon_Warlord() : base()
        {
            MultiverseId = 208;
            Name = "Keldon Warlord";
            Add(Enumerations.Colors.Red);
            Add(Enumerations.SubType.Human);
            Add(Enumerations.SubType.Barbarian);
            Add(Enumerations.CardType.Creature);
            //_Power = *;
            //	_Toughness = *;

            throw new NotImplementedException("Keldon Warlord");
        }
        public Keldon_Warlord(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
