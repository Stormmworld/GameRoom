using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Black_Lotus : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=3
            *  
            *  {T}, Sacrifice Black Lotus: Add three mana of any one color to your mana pool.
            *  
            * Rulings

            *  
            */
        public Black_Lotus() : base()
        {
            MultiverseId = 3;
            Name = "Black Lotus";
	        Add(Enumerations.CardType.Artifact);
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Blue, Count = 3 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 3 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Green, Count = 3 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 3 }) { RequiresTap = true });
            Add(new Abilities.Activated.ManaSource(new Mana() { Color = Enumerations.Colors.White, Count = 3 }) { RequiresTap = true });
            Add(new Abilities.Triggered.Sacrifice(Enumerations.EffectTrigger.Card_AbilityCompleted, Enumerations.TargetScope.Self, new Target() { Type= Enumerations.TargetType.Card, Id = Id}));
        }
        public Black_Lotus(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
