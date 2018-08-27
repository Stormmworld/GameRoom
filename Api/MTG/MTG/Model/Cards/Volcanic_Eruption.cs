using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Volcanic_Eruption : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=136
        *  
        *  Destroy X target Mountains. Volcanic Eruption deals damage to each creature and each player equal to the number of Mountains put into a graveyard this way.
        *  
        * Rulings
        * 2004-10-04: Can be used with X equal to zero. This is useful if no Mountains are on the battlefield.

        *
        */
        public Volcanic_Eruption() : base()
        {
            MultiverseId = 136;
            Name = "Volcanic Eruption";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Volcanic Eruption");
        }
        public Volcanic_Eruption(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
