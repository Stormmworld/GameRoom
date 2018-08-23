using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Wooden_Sphere : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=47
            *  
            *  Whenever a player casts a green spell, you may pay {1}. If you do, you gain 1 life.
            *  
            * Rulings

            *  
            */
        public Wooden_Sphere() : base()
        {
            MultiverseId = 47;
            Name = "Wooden Sphere";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Wooden Sphere");
        }
        public Wooden_Sphere(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
