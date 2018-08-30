using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Collections.Generic;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Ankh_of_Mishra : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=1
        *  
        *  Whenever a land enters the battlefield, Ankh of Mishra deals 2 damage to that land's controller.
        *  
        * Rulings
        * 2004-10-04: This triggers on any land entering the battlefield. This includes playing a land or putting a land onto the battlefield using a spell or ability.
        * 2004-10-04: It determines the land's controller at the time the ability resolves. If the land leaves the battlefield before the ability resolves, the land's last controller before it left is used.
        *
        */
        public Ankh_of_Mishra() : base()
        {
            MultiverseId = 1;
            Name = "Ankh of Mishra";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            Add(CardType.Artifact);
            Add(new TriggeredDamage(EffectTrigger.LandEntersBattlefield, new TargetRequirements(TargetScope.Controller, new List<TargetType>() { TargetType.Player }), new Damage(this, 2)));
        }
        public Ankh_of_Mishra(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
