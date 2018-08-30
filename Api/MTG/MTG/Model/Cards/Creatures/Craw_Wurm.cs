using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Craw_Wurm : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=146
        *  
        *  
        *  
        * Rulings
        *
        */
        public Craw_Wurm() : base()
        {
            MultiverseId = 146;
            Name = "Craw Wurm";
            Set(6, 4);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Wurm);
            Add(CardType.Creature);
        }
        public Craw_Wurm(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
