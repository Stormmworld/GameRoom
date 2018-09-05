using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Drain_Power : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=104
        *  
        *  Target player activates a mana ability of each land he or she controls. Then put all mana from that player's mana pool into yours.
        *  
        * Rulings
        * 2004-10-04: This card forces the target player to draw mana from lands if they are untapped, but that player can choose how to draw the mana if a land he or she controls has multiple mana abilities, or mana abilities with choices.
        * 2004-10-04: Your opponent may use instants and abilities of permanents in response to this spell before you get the mana from their mana pool and lands.
        * 2004-10-04: If a land can draw a variable amount of mana, the target player (not the player of this spell) chooses how much to draw.
        * 2013-04-15: A mana ability is an ability that (1) isn't a loyalty ability, (2) doesn't target, and (3) could put mana into a player's mana pool when it resolves.

        *
        */
        public Drain_Power() : base()
        {
            MultiverseId = 104;
            Name = "Drain Power";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            Add(Color.Blue);
            Add(CardType.Sorcery);

            throw new NotImplementedException("Drain Power");
        }
        public Drain_Power(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
