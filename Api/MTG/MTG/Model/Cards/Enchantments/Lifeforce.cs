using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Effects;
using MTG.Model.Abilities.Activated;
using MTG.Model.Data_Objects;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards
{
    public class Lifeforce : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=162
        *  
        *  {G}{G}: Counter target black spell.
        *  
        * Rulings

        *
        */
        public Lifeforce() : base()
        {
            MultiverseId = 162;
            Name = "Lifeforce";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Enchantment);
            Add(new EffectGenerator(true, new List<IManaCost>() { new ManaCost(new Mana(Color.Green, 2)) }, typeof(CounterspellEffect), new TargetRequirements(TargetScope.Single,  TargetType.Card, new TargetCardRequirements() { HasColor = Color.Black, InZone = TargetZone.Stack }), GamePhase.None));
        }
        public Lifeforce(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
