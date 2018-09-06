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
    public class Deathgrip : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=56
        *  
        *  {B}{B}: Counter target green spell.
        *  
        * Rulings
        *
        */
        public Deathgrip() : base()
        {
            MultiverseId = 56;
            Name = "Deathgrip";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Enchantment);
            Add(new EffectGenerator(true,new List<IManaCost>() { new ManaCost(new Mana(Color.Black, 2))}, typeof(CounterspellEffect), new TargetRequirements(TargetScope.Single, TargetType.Card , new TargetCardRequirements() { HasColor = Color.Green, InZone = TargetZone.Stack }), GamePhase.None));
        }
        public Deathgrip(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
