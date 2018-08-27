using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Darkpact : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=55
        *  
        *  Remove Darkpact from your deck before playing if you're not playing for ante.
You own target card in the ante. Exchange that card with the top card of your library.
        *  
        * Rulings

        *
        */
        public Darkpact() : base()
        {
            MultiverseId = 55;
            Name = "Darkpact";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Darkpact");
        }
        public Darkpact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
