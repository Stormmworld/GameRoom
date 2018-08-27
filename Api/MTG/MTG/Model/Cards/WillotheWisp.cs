using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class WillotheWisp : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=91
        *  
        *  Flying (This creature can't be blocked except by creatures with flying or reach.)
{B}: Regenerate Will-o'-the-Wisp. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
        *  
        * Rulings

        *
        */
        public WillotheWisp() : base()
        {
            MultiverseId = 91;
            Name = "Will-o'-the-Wisp";
            Set(0, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Spirit);
            Add(CardType.Creature);

            throw new NotImplementedException("Will-o'-the-Wisp");
        }
        public WillotheWisp(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
