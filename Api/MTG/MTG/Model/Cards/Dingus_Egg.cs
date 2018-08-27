using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Dingus_Egg : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=12
        *  
        *  Whenever a land is put into a graveyard from the battlefield, Dingus Egg deals 2 damage to that land's controller.
        *  
        * Rulings

        *
        */
        public Dingus_Egg() : base()
        {
            MultiverseId = 12;
            Name = "Dingus Egg";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Dingus Egg");
        }
        public Dingus_Egg(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
