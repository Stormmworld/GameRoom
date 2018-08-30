using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Wall_of_Bone : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=88
        *  
        *  Defender (This creature can't attack.)
        *  {B}: Regenerate Wall of Bone. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
        *  
        * Rulings

        *
        */
        public Wall_of_Bone() : base()
        {
            MultiverseId = 88;
            Name = "Wall of Bone";
            Set(1, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Skeleton);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new Abilities.Activated.RegenerationAbility(new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Black, 1))}),false));
        }
        public Wall_of_Bone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
