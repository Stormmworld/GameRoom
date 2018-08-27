using MTG.Enumerations;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface ITargetCardRequirements
    {
        Color HasColors { get; }
        CardType HasType { get; }
        SubType HasSubType { get; }
        SuperType HasSuperType { get; }
        TargetZone InZone { get; }

        void Assign(Color color);
        void Assign(CardType type);
        void Assign(SubType subType);
        void Assign(SuperType superType);
        void Assign(TargetZone zone);
    }
}
