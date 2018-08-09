using MTG.Enumerations;
using MTG.Model.Objects;

namespace MTG.Interfaces
{
    public interface IEffect
    {
        Target Target { get; }
        GamePhases EndingPhase { get; }
        int Value { get; }
    }
}
