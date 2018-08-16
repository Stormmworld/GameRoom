
using System.Collections.Generic;
using MTG.Enumerations;

namespace MTG.Interfaces
{
    public interface ISpellAbility : IAbility
    {
        TargetScope TargetScope { get;  }
        bool RequiresTarget { get;  }
        List<TargetType> TargetTypes { get;  }
    }
}
