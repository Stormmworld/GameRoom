using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Black_Lotus : Permanent
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
            Add(CardType.Artifact);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Blue, 3) }, true));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Black, 3) }, true));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Red, 3) }, true));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 3) }, true));
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.White, 3) }, true));
        }
        public Black_Lotus(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
