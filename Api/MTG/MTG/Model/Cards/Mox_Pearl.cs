using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Mox_Pearl : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=34
            *  
            *  {T}: Add {W} to your mana pool.
            *  
            * Rulings

            *  
            */
        public Mox_Pearl() : base()
        {
            MultiverseId = 34;
            Name = "Mox Pearl";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Mox Pearl");
        }
        public Mox_Pearl(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
