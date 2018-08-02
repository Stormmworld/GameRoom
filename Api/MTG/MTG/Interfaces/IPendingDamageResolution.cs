using MTG.Model.Objects;

namespace MTG.Interfaces
{
    public interface IPendingDamageResolution
    {
        int Damage { get; set; }
        Card OriginCard { get; set; }
    }
}
