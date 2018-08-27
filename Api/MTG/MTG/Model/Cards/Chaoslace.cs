using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Chaoslace : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=187
        *  
        *  Target spell or permanent becomes red. (Its mana symbols remain unchanged.)
        *  
        * Rulings

        *
        */
        public Chaoslace() : base()
        {
            MultiverseId = 187;
            Name = "Chaoslace";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(CardType.Instant);

            throw new NotImplementedException("Chaoslace");
        }
        public Chaoslace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
