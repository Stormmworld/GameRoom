using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Timetwister : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=132
        *  
        *  Each player shuffles his or her hand and graveyard into his or her library, then draws seven cards. (Then put Timetwister into its owner's graveyard.)
        *  
        * Rulings
        * 2013-07-01: This card won't be put into your graveyard until after it's finished resolving, which means it won't be shuffled into your library as part of its own effect.

        *
        */
        public Timetwister() : base()
        {
            MultiverseId = 132;
            Name = "Timetwister";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Timetwister");
        }
        public Timetwister(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
