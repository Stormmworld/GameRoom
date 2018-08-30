﻿using MTG.Enumerations;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Abilities._Base;
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
        #endregion

        #region Constructors
        public UpkeepManaCost(List<IManaCost> manaCosts):base((EffectTrigger.Phases_BegginingPhase_UpkeepStep))
        {
            _ManaCosts = new List<IManaCost>();
            _ManaCosts.AddRange(manaCosts);
        }
        #endregion
    }
}