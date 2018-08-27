using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Balance : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=234
        *  
        *  Each player chooses a number of lands he or she controls equal to the number of lands controlled by the player who controls the fewest, then sacrifices the rest. Players discard cards and sacrifice creatures the same way.
        *  
        * Rulings
        * 2016-06-08: First the player whose turn it is chooses which lands (if any) to keep, then each other player in turn order does the same. Each player will know the choices made by the players who chose before them. All of the unchosen lands are then sacrificed simultaneously. Then the process is repeated for cards in hand, except that no cards are revealed until all players have chosen what to discard, at which point those cards are all discarded simultaneously. Lastly, the process is repeated for creatures, and players will again know earlier choices made when deciding what to sacrifice. All of the unchosen creatures are then sacrificed simultaneously.
        * 2016-06-08: Balance doesn't have targets, so permanents that can't be targeted, such as a creature with shroud or protection from white, are valid choices to be sacrificed.
        * 2016-06-08: Each type of object is counted during the corresponding part of the process. Cards in hand are counted after lands have been sacrificed, and creatures on the battlefield are counted after cards have been discarded. Thus, a land creature sacrificed to the first part of the spell would not be counted when determining how many creatures are on the battlefield for the last part.
        *
        */
        public Balance() : base()
        {
            MultiverseId = 234;
            Name = "Balance";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Balance");
        }
        public Balance(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
