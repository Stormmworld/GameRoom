using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Bad_Moon : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=49
            *  
            *  Black creatures get +1/+1.
            *  
            * Rulings

            *  
            */
        public Bad_Moon() : base()
        {
            MultiverseId = 49;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Black, Count = 1 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            Name = "Bad Moon";
	        Add(Enumerations.Colors.Black);
	        Add(Enumerations.CardType.Enchantment);
            Add(new EffectGenerator(Enumerations.EffectTrigger.Card_EntersBattleField, new PlusXPlusY(Id, 1,1, Enumerations.TargetScope.All, new List<Enumerations.TargetType>() {  Enumerations.TargetType.Creature }, new List<Enumerations.Colors>() { Enumerations.Colors.Black})));
        }
        public Bad_Moon(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
