using MTG.ArgumentDefintions;
using MTG.Enumerations;
using System.Collections.Generic;

namespace MTG.Interfaces
{
    public interface IAbility
    {
        IReadOnlyCollection<AbilityType> Types { get; }
        EffectTrigger Trigger { get;  }

        AbilityProcessedEventArgs Process(AbilityArgs args);
    }
}
