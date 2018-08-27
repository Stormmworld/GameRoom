using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Copper_Tablet : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=9
        *  
        *  At the beginning of each player's upkeep, Copper Tablet deals 1 damage to that player.
        *  
        * Rulings

        *
        */
        public Copper_Tablet() : base()
        {
            MultiverseId = 9;
            Name = "Copper Tablet";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Copper Tablet");
        }
        public Copper_Tablet(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
