using MTG.Enumerations;
using MTG.Model;
using MTG.Model.Objects;
using System;

namespace MTG_Test.Mockers
{
    public static class Target_Mocker
    {
        public static Target Mock()
        {
            return new Target()
            {
                Id = Guid.NewGuid(),
                Type = MTG.Enumerations.TargetType.None,
            };
        }
        public static Target Mock(Player targetPlayer)
        {
            return new Target()
            {
                Id = targetPlayer.Id,
                Type = TargetType.Player,
            };
        }
        public static Target Mock(Card targetCard)
        {
            return new Target()
            {
                Id = targetCard.Id,
                Type = TargetType.Card,
            };
        }
    }
}
