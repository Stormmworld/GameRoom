using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;

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
            Add(new ColorModification(abilityCost, new TargetRequirements(TargetScope.Single, TargetType.Card ), Color.Red, true, false));
        }
        public Chaoslace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
