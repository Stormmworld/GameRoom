using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Counters;
using System.Linq;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Living_Artifact : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=164
        *  
        *  Enchant artifact
        *   Whenever you're dealt damage, put that many vitality counters on Living Artifact.
        *   At the beginning of your upkeep, you may remove a vitality counter from Living Artifact. If you do, you gain 1 life.
        *  
        * Rulings
        * 2004-10-04: You can cast it targeting your opponent's artifacts. The controller of the Aura (not the controller of the artifact) controls the Living Artifact ability.
        * 2004-10-04: Does not trigger on loss of life, just on damage.
        *
        */
        #region Constructors
        public Living_Artifact() :  base(new TargetCardRequirements() { HasType = CardType.Artifact })
        {
            MultiverseId = 164;
            Name = "Living Artifact";
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new CounterGenerator( EffectTrigger.ControllerDamaged, new TargetRequirements(TargetScope.Self, TargetType.Card), new Vitality()));
            EffectGeneratorTriggered triggeredAbility = new EffectGeneratorTriggered(EffectTrigger.Phases_BegginingPhase_UpkeepStep, new TargetRequirements(TargetScope.Owner, TargetType.Player), typeof(GainLifeEffect)) { AmountType = AmountType.Defined, Value = 1};
            triggeredAbility.OnProcessing += UseCounter_OnProcessing;
            Add(triggeredAbility);
        }
        public Living_Artifact(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
        #endregion

        #region Event Handlers
        private void UseCounter_OnProcessing(object sender, EventArgs e)
        {
            if (Counters.Where(o => o is Vitality).Count() < 1)
                throw new Exception("There are no Vitality counters to consume");
            else
                Remove(Counters.First(o => o is Vitality));
        }
        #endregion
    }
}
