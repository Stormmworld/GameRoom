using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Dingus_Egg : Card
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
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Dingus Egg");
        }
        public Dingus_Egg(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
