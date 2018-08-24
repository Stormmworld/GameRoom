using MTG.Model.Abilities.Triggered;
using MTG.Model.Effects;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Crusade : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=247
            *  
            *  White creatures get +1/+1.
            *  
            * Rulings

            *  
            */
        public Crusade() : base()
        {
            MultiverseId = 247;
            Name = "Crusade";
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.White, Count = 2 } });
            Add(Enumerations.Colors.White);
            Add(Enumerations.CardType.Enchantment);
            Add(new EffectGenerator(Enumerations.EffectTrigger.Card_EntersBattleField, new PlusXPlusY(Id, 1, 1, Enumerations.TargetScope.All, new List<Enumerations.TargetType>() { Enumerations.TargetType.Creature }, new List<Enumerations.Colors>() { Enumerations.Colors.Black })));
        }
        public Crusade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
