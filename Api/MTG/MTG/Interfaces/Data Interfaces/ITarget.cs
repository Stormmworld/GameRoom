using MTG.Enumerations;
using System;

namespace MTG.Interfaces.Data_Interfaces
{
    public interface ITarget
    {
        TargetType Type { get; }
        Guid Id { get; }
    }
}