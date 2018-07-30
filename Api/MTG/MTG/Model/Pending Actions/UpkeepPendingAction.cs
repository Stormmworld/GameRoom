using MTG.Interfaces;
using MTG.Model.Objects;

namespace MTG.Model.Pending_Actions
{
    public class UpkeepPendingAction
    {
        public class Scry : IPendingAction
        {
            /*
                 */
            #region Properties
            public int ActionPlayerId { get; set; }
            public UpkeepRequirement Requirement { get; set; }
            #endregion

        }
    }
}
