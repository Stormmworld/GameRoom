using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Swords : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=273
            *  
            *  Defender (This creature can't attack.)
                Flying
            *  
            * Rulings

            *  
            */
        public Wall_of_Swords() : base()
        {
            MultiverseId = 273;
            Name = "Wall of Swords";
            _Power = 3;
            _Toughness = 5;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.White, Count = 1 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(Enumerations.Colors.White);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            Add(new Flying());
        }
        public Wall_of_Swords(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
