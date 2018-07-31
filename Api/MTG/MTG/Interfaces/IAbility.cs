using MTG.ArgumentDefintions;
using MTG.Enumerations;

namespace MTG.Interfaces
{
    public interface IAbility
    {
        EffectTrigger trigger { get; set; } 

        void Process(AbilityArgs args);
    }
}
