using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Deathgrip : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=56
        *  
        *  {B}{B}: Counter target green spell.
        *  
        * Rulings

        *
        */
        public Deathgrip() : base()
        {
            MultiverseId = 56;
            Name = "Deathgrip";
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Deathgrip");
        }
        public Deathgrip(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
