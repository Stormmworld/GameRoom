using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Throne_of_Bone : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=44
            *  
            *  Whenever a player casts a black spell, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings

            *  
            */
        public Throne_of_Bone() : base()
        {
            MultiverseId = 44;
            Name = "Throne of Bone";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Throne of Bone");
        }
        public Throne_of_Bone(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
