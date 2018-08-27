using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Goblin_Balloon_Brigade : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=201
        *  
        *  {R}: Goblin Balloon Brigade gains flying until end of turn.
        *  
        * Rulings
        * 2008-08-01: You can activate the ability repeatedly during a turn. This generally has no additional effect, unless some other effect (like that from Adarkar Windform has caused it to lose flying since the last time the ability resolved.
        * 2010-08-15: For flying to work as an evasion ability, an attacking Goblin Balloon Brigade's ability must be activated before the declare blockers step begins. Once Goblin Balloon Brigade has become blocked, giving it flying won't change that.

        *
        */
        public Goblin_Balloon_Brigade() : base()
        {
            MultiverseId = 201;
            Name = "Goblin Balloon Brigade";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Goblin);
            Add(SubType.Warrior);
            Add(CardType.Creature);

            throw new NotImplementedException("Goblin Balloon Brigade");
        }
        public Goblin_Balloon_Brigade(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
