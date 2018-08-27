using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Copy_Artifact : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=101
        *  
        *  You may have Copy Artifact enter the battlefield as a copy of any artifact on the battlefield, except it's an enchantment in addition to its other types.
        *  
        * Rulings
        * 2004-10-04: The copy is both an artifact and an enchantment, so it is an artifact-enchantment (perhaps even an artifact-creature-enchantment). It can be affected by anything which affects either type of permanent.
        * 2004-10-04: The copy of the artifact is not still blue. It copies the color of the thing it is copying.
        * 2004-10-04: The artifact to copy is chosen at the time this card enters the battlefield. If there is no valid artifact to choose, then this card enters the battlefield as an enchantment that has no effect.

        *
        */
        public Copy_Artifact() : base()
        {
            MultiverseId = 101;
            Name = "Copy Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Copy Artifact");
        }
        public Copy_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
