using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Conversion : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=246
        *  
        *  At the beginning of your upkeep, sacrifice Conversion unless you pay {W}{W}.
        *  All Mountains are Plains.
        *  
        * Rulings
        * 2004-10-04: The Conversion effect is a continuous effect. There is no chance to tap a just-played mountain for red mana before it becomes a plains.
        * 2006-10-15: Will not add or remove Snow Supertype to or from a land.

        *
        */
        public Conversion() : base()
        {
            MultiverseId = 246;
            Name = "Conversion";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);
            Add(new ConvertSubType(SubType.Mountain, SubType.Plains, Id));
            Add(new UpkeepManaCost(new List<IManaCost>() { new ManaCost(new Mana(Color.White,2)) }));
        }
        public Conversion(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
