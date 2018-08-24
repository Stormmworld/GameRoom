using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Wall_of_Fire : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=229
            *  
            *  Defender (This creature can't attack.)
                {R}: Wall of Fire gets +1/+0 until end of turn.
            *  
            * Rulings

            *  
            */
        public Wall_of_Fire() : base()
        {
            MultiverseId = 229;
            Name = "Wall of Fire";
            _Power = 0;
            _Toughness = 5;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Red, Count = 2 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 1 } });
            Add(Enumerations.Colors.Red);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            CastingCost activationCost = new CastingCost();
            activationCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Red, Count = 1 } });
            Add(new Abilities.Activated.PlusXPlusY(activationCost, 1,0, false));
        }
        public Wall_of_Fire(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
