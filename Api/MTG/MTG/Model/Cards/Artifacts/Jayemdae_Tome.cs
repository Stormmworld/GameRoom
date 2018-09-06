using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Jayemdae_Tome : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=25
        *  
        *  {4}, {T}: Draw a card.
        *  
        * Rulings
        *
        */
        public Jayemdae_Tome() : base()
        {
            MultiverseId = 25;
            Name = "Jayemdae Tome";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);
            Add(new EffectGenerator(true,new List<IManaCost>() { new ManaCost(new Mana( Color.Colorless, 4))} ,typeof(DrawCardsEffect), new TargetRequirements(TargetScope.Controller, TargetType.Player), GamePhase.None));
        }
        public Jayemdae_Tome(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
