using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Sirens_Call : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=125
        *  
        *  Cast Siren's Call only during an opponent's turn, before attackers are declared.
Creatures the active player controls attack this turn if able.
At the beginning of the next end step, destroy all non-Wall creatures that player controls that didn't attack this turn. Ignore this effect for each creature the player didn't control continuously since the beginning of the turn.
        *  
        * Rulings
        * 2004-10-04: It will require creatures with Haste to attack since they are able, but it won't destroy them if they don't for some reason.
        * 2004-10-04: The creature is destroyed if it does not attack because it simply can't do so legally.
        * 2009-02-01: This will destroy creatures that weren't able to attack because they had been previously tapped.
        * 2013-09-20: If a turn has multiple combat phases, this spell can only be cast before the beginning of the Declare Attackers Step of the first combat phase in that turn.

        *
        */
        public Sirens_Call() : base()
        {
            MultiverseId = 125;
            Name = "Siren's Call";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Instant);

            throw new NotImplementedException("Siren's Call");
        }
        public Sirens_Call(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
