using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Northern_Paladin : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=260
        *  
        *  {W}{W}, {T}: Destroy target black permanent.
        *  
        * Rulings

        *
        */
        public Northern_Paladin() : base()
        {
            MultiverseId = 260;
            Name = "Northern Paladin";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(SubType.Human);
            Add(SubType.Knight);
            Add(CardType.Creature);

            throw new NotImplementedException("Northern Paladin");
        }
        public Northern_Paladin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
