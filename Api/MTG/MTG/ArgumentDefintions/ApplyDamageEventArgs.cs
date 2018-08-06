using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;
using System;
using System.Collections.Generic;

namespace MTG.ArgumentDefintions
{
    public class ApplyDamageEventArgs: EventArgs
    {
        #region Variables
        private List<DamageTypes> _Types;
        private List<Colors> _Colors;
        #endregion

        #region Properties
        public IReadOnlyList<Colors> Colors { get { return _Colors.AsReadOnly(); } }
        public int DamageValue { get; set; }
        public Target Target { get; set; }
        public IReadOnlyList<DamageTypes> Types { get { return _Types.AsReadOnly(); } }
        #endregion

        #region Constructors
        public ApplyDamageEventArgs()
        {
            Target = new Target();
            _Types = new List<DamageTypes>();
        }
        #endregion

        #region Methods
        public void addDamageAttributtes(Card originCard)
        {
            if (originCard.HasAbility(typeof(Deathtouch)))
                _Types.Add(DamageTypes.Deathtouch);
            if (originCard.HasAbility(typeof(Trample)))
                _Types.Add(DamageTypes.Trample);
            foreach (Colors color in originCard.Colors)
                _Colors.Add(color);
        }
        #endregion
    }
}
