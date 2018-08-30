using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Interfaces.Mana_Interfaces;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Wall_of_Brambles : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=179
        *  
        *  Defender (This creature can't attack.)
        *  {G}: Regenerate Wall of Brambles.
        *  
        * Rulings

        *
        */
        public Wall_of_Brambles() : base()
        {
            MultiverseId = 179;
            Name = "Wall of Brambles";
            Set(2, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Plant);
            Add(SubType.Wall);
            Add(CardType.Creature);
            Add(new Defender());
            Add(new Abilities.Activated.RegenerationAbility(new CastingCost(new List<IManaCost>() { new ManaCost(new Mana(Color.Green, 1)) }), false));
        }
        public Wall_of_Brambles(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
