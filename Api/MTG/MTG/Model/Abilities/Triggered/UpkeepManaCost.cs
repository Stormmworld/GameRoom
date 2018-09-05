using MTG.Enumerations;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
using MTG.Model.Data_Objects;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Triggered
{
    public class UpkeepManaCost:TriggeredAbility
    {
        #region Variables
        private List<IManaCost> _ManaCosts;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IManaCost> ManaCosts { get { return _ManaCosts.AsReadOnly(); } }
        public FailedUpkeepResult FailedUpkeepResult { get; private set; }
        #endregion

        #region Constructors
        public UpkeepManaCost(List<IManaCost> manaCosts):base((EffectTrigger.Phases_BegginingPhase_UpkeepStep))
        {
            _ManaCosts = new List<IManaCost>();
            _ManaCosts.AddRange(manaCosts);
        }
        public UpkeepManaCost(List<IManaCost> manaCosts, FailedUpkeepResult failedUpkeepResult) : this(manaCosts)
        {
            FailedUpkeepResult = failedUpkeepResult;
        }
        #endregion
    }
}
