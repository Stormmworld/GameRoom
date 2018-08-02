using MTG.Enumerations;

namespace MTG.Helpers
{
    public static class TargetHelper
    {
        public static bool TargetIsCard(TargetType type)
        {
            switch (type)
            {
                case TargetType.Artifact:
                case TargetType.Creature:
                case TargetType.Land:
                case TargetType.Permanent:
                case TargetType.Planeswalker:
                    return true;
                default:
                    return false;
            }
        }
    }
}
