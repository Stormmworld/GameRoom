using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Plague_Rats : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=77
            *  
            *  Plague Rats's power and toughness are each equal to the number of creatures named Plague Rats on the battlefield.
            *  
            * Rulings

            *  
            */
        public Plague_Rats() : base()
        {
            MultiverseId = 77;
            Name = "Plague Rats";
            Add(Enumerations.Colors.Black);
            Add(Enumerations.SubType.Rat);
            Add(Enumerations.CardType.Creature);
            //_Power = *;
            //	_Toughness = *;

            throw new NotImplementedException("Plague Rats");
        }
        public Plague_Rats(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
