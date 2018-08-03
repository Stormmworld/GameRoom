using System.Collections.Generic;

namespace MTG.Model.Objects
{
    public class UpkeepAction
    {
        #region Properties
        public List<Mana> ManaRequirements { get; set; }
        public bool RequiresInteraction { get; private set; }
        public Sacrifice SacrificeRequirement { get; set; }
        public bool Success { get; private set; }
        #endregion

        #region Constructors
        public UpkeepAction()
        {
            ManaRequirements = new List<Mana>();
            SacrificeRequirement = new Sacrifice();
        }
        public UpkeepAction(UpkeepAction action)
        {
            foreach (Mana mana in ManaRequirements)
                ManaRequirements.Add(new Mana(mana));
            RequiresInteraction = action.RequiresInteraction;
            SacrificeRequirement = action.SacrificeRequirement;
            Success = action.Success;
        }
        #endregion

        #region Methods
        public void Multiplier(int multiplier)
        {
            if (SacrificeRequirement.Type == Enumerations.SacrificeType.Count)
                SacrificeRequirement.Count = SacrificeRequirement.Count * multiplier;
            foreach (Mana mana in ManaRequirements)
                mana.Count = mana.Count * multiplier;
        }
        #endregion
    }
}
