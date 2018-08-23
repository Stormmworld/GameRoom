using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mind_Twist : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=71
            *  
            *  Target player discards X cards at random.
            *  
            * Rulings

            *  
            */
        public Mind_Twist() : base()
        {
            MultiverseId = 71;
            Name = "Mind Twist";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Sorcery);

            throw new NotImplementedException("Mind Twist");
        }
        public Mind_Twist(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
