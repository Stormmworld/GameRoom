using MTG.ArgumentDefintions;

namespace MTG.Interfaces
{
    public interface IAbility
    {
        void Process(AbilityArgs args);
    }
}
