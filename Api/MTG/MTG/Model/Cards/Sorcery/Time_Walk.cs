using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    class Time_Walk : Card
    {
        /*
         * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=131
         * 
         * Take an extra turn after this one.
         * 
         * Rulings
         * If multiple “extra turn” effects resolve in the same turn, take them in the reverse of the order that the effects resolved.
         */
        public Time_Walk() : base()
        {
            CastingCost castingCost = new CastingCost();
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Blue, Count = 1 } });
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            ICastingAbility ability = new ExtraTurn(7, Enumerations.TargetScope.Self, new System.Collections.Generic.List<Enumerations.TargetType>() { Enumerations.TargetType.Player }, false, castingCost, this);

            MultiverseId = 131;
            Name = "Time Walk";
            Add(Enumerations.CardType.Sorcery);
            Add(Enumerations.Colors.Blue);
        }
        public Time_Walk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}