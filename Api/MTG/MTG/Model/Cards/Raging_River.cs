using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Raging_River : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=216
        *  
        *  Whenever one or more creatures you control attack, each defending player divides all creatures without flying he or she controls into a "left" pile and a "right" pile. Then, for each attacking creature you control, choose "left" or "right." That creature can't be blocked this combat except by creatures with flying and creatures in a pile with the chosen label.
        *  
        * Rulings
        * 2008-05-01: If a creature enters the battlefield (or something becomes a creature) after the ability resolves, that creature will not be able to block any creature that was attacking at the time the ability resolved.
        * 2008-05-01: If a creature is put onto the battlefield attacking after the ability resolves, it can be blocked by any creature that could normally block it (including others creatures that entered the battlefield after the ability resolved).

        *
        */
        public Raging_River() : base()
        {
            MultiverseId = 216;
            Name = "Raging River";
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Enchantment);

            throw new NotImplementedException("Raging River");
        }
        public Raging_River(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
