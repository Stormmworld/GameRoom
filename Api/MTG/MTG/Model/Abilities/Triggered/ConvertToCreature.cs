using MTG.Enumerations;
using MTG.Model.Abilities._Base;

namespace MTG.Model.Abilities.Triggered
{
    public class ConvertToCreature : TriggeredAbility
    {
        #region Properties
        public int Power { get; private set; }
        public ConversionModifier PowerModifier { get; private set; }
        public int Toughness { get; private set; }
        public ConversionModifier ToughnessModifier { get; private set; }
        #endregion

        #region Constructors
        public ConvertToCreature(EffectTrigger trigger, ConversionModifier powerModifier, ConversionModifier toughnessModifier) : base(trigger)
        {
            PowerModifier = powerModifier;
            ToughnessModifier = toughnessModifier;
        }
        public ConvertToCreature(EffectTrigger trigger, int power, int toughness) : this(trigger, ConversionModifier.Assigned, ConversionModifier.Assigned)
        {
            Power = power;
            Toughness = toughness;
        }
        #endregion
    }
}
