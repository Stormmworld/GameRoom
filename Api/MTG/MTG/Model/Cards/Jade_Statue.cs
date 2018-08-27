using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Jade_Statue : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=24
        *  
        *  {2}: Jade Statue becomes a 3/6 Golem artifact creature until end of combat. Activate this ability only during combat.
        *  
        * Rulings
        * 2004-10-04: It can only make itself into a creature during combat phases and therefore it is difficult to get Auras placed on it.
        * 2005-08-01: A delayed triggered ability that refers to Jade Statue still affects it even if it's no longer a creature. For example, if Jade Statue blocks the Kashi-Tribe Warriors ("Whenever Kashi-Tribe Warriors deals combat damage to a creature, tap that creature and it doesn't untap during its controller's next untap step."), the Warriors' effect stops Jade Statue from untapping.
        * 2005-08-01: If Jade Statue's ability has been activated, abilities that trigger "at end of combat" will see Jade Statue as an artifact creature.
        * 2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.
        * 2013-09-20: If Jade Statue is animated by some other effect, you get an artifact creature with whatever power, toughness, and creature types (if any) are specified by that effect. If you subsequently use Jade Statue's ability during combat, it will become 3/6 and gain the creature type Golem in addition to those creature types until end of combat.

        *
        */
        public Jade_Statue() : base()
        {
            MultiverseId = 24;
            Name = "Jade Statue";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Jade Statue");
        }
        public Jade_Statue(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
