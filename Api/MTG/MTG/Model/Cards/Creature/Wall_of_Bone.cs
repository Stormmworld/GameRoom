using MTG.Model.Abilities.Static;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wall_of_Bone : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=88
            *  
            *  Defender (This creature can't attack.)
                {B}: Regenerate Wall of Bone. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
            *  
            * Rulings

            *  
            */
        public Wall_of_Bone() : base()
        {
            MultiverseId = 88;
            Name = "Wall of Bone";
            _Power = 1;
            _Toughness = 4;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Black, Count = 1 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 2 } });
            Add(Enumerations.Colors.Black);
            Add(Enumerations.SubType.Skeleton);
            Add(Enumerations.SubType.Wall);
            Add(Enumerations.CardType.Creature);
            Add(new Defender());
            CastingCost regenerationCost = new CastingCost();
            regenerationCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Black, Count = 1 } });
            Add(new Abilities.Activated.Regeneration(regenerationCost));
        }
        public Wall_of_Bone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
