using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Ancestral_Recall : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=95
            *  
            *  Target player draws three cards.
            *  
            * Rulings

            *  
            */
        public Ancestral_Recall() : base()
        {
            MultiverseId = 95;
            Name = "Ancestral Recall";
	        Add(Enumerations.Colors.Blue);
	        Add(Enumerations.CardType.Instant);

            CastingCost castingCost = new CastingCost();
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Blue, Count = 1 } });
            ICastingAbility ability = new DrawCards(3, castingCost, new List<Enumerations.TargetType>() { Enumerations.TargetType.Player }, Enumerations.TargetScope.Single, true);
        }
        public Ancestral_Recall(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
