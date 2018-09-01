using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Casting;

namespace MTG.Model.Cards
{
    public class Deathlace : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=57
        *  
        *  Target spell or permanent becomes black. (Mana symbols on that permanent remain unchanged.)
        *  
        * Rulings

        *
        */
        public Deathlace() : base()
        {
            MultiverseId = 57;
            Name = "Deathlace";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);
            Add(new ColorModification(abilityCost, new TargetRequirements(TargetScope.Single,TargetType.Card), Color.Black, true, false));
        }
        public Deathlace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
