using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Brambles : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=179
            *  
            *  Defender (This creature can't attack.)
                {G}: Regenerate Wall of Brambles.
            *  
            * Rulings

            *  
            */
        public Wall_of_Brambles() : base()
        {
            MultiverseId = 179;
            Name = "Wall of Brambles";
            _Power = 2;
            _Toughness = 3;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 1 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 2 } });
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Plant);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            CastingCost regenerationCost = new CastingCost();
            regenerationCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Green, Count = 1 } });
            Add(new Abilities.Activated.Regeneration(regenerationCost));
        }
        public Wall_of_Brambles(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
