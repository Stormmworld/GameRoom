using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Birds_of_Paradise : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=142
            *  
            *  Flying
                {T}: Add one mana of any color to your mana pool.
            *  
            * Rulings

            *  
            */
        public Birds_of_Paradise() : base()
        {
            MultiverseId = 142;
            Name = "Birds of Paradise";
            _Power = 0;
            _Toughness = 1;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 1 } });
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Bird);
            Add(Enumerations.CardType.Creature);
            Add(new Flying());
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 1 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 1 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 1 }) { RequiresTap = true });
        }
        public Birds_of_Paradise(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
