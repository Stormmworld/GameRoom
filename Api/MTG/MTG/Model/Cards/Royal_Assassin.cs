using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Royal_Assassin : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=79
        *  
        *  {T}: Destroy target tapped creature.
        *  
        * Rulings
        * 2004-10-04: Can't target itself because you choose the target before you tap him. At that time he is not yet a legal target.
        * 2004-10-04: If the creature is no longer tapped when the Assassin's ability resolves, then the ability is countered.

        *
        */
        public Royal_Assassin() : base()
        {
            MultiverseId = 79;
            Name = "Royal Assassin";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Human);
            Add(SubType.Assassin);
            Add(CardType.Creature);

            throw new NotImplementedException("Royal Assassin");
        }
        public Royal_Assassin(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
