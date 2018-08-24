using MTG.Enumerations;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Braingeyser : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=98
            *  
            *  Target player draws X cards.
            *  
            * Rulings

            *  
            */
        public Braingeyser() : base()
        {
            MultiverseId = 98;
            Name = "Braingeyser";
            Add(Enumerations.Colors.Blue);
            Add(CardType.Sorcery);
            CastingCost castingCost = new CastingCost();
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Blue, Count = 2 } });
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, XCount = true } });
            Add(new DrawCards(0,castingCost, new List<TargetType>() { TargetType.Player }, TargetScope.Single, true, true));
        }
        public Braingeyser(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
