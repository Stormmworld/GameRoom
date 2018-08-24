using MTG.Enumerations;
using MTG.Interfaces;
using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Abilities.Activated
{
    public class ManaConversion : IActivatedAbility
    {
        /*
        * ManaConversion
             
        */
        #region Events
        public event EventHandler OnPendingActionTriggered, OnEffectTriggered, OnEffectTrigger, OnCardEvent;
        #endregion

        #region Variables
        #endregion

        #region Properties
        public CastingCost ActivationCost { get; private set; }
        public Colors ConvertedManaColor { get; private set; }
        public Guid Id { get; private set; }
        public bool RequiresTap { get; private set; }
        #endregion

        #region Constructors
        private ManaConversion()
        {
            Id = Guid.NewGuid();
            ActivationCost = new CastingCost();
        }
        public ManaConversion(Colors originManaColor, Colors oonvertedManaColor) : this()
        {
            ActivationCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = originManaColor, Count = 1 } });
            ConvertedManaColor = ConvertedManaColor;
        }
        #endregion

        #region Methods
        public bool Activate(IActivationArgs e)
        {
            throw new NotImplementedException("ManaConversion.Activate");
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion
    }
}
