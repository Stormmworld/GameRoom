using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Bog_Wraith : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=51
        *  
        *  Swampwalk (This creature can't be blocked as long as defending player controls a Swamp.)
        *  
        * Rulings

        *
        */
        public Bog_Wraith() : base()
        {
            MultiverseId = 51;
            Name = "Bog Wraith";
            Set(3, 3);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Wraith);
            Add(CardType.Creature);

            throw new NotImplementedException("Bog Wraith");
        }
        public Bog_Wraith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
