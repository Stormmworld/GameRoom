using MTG.Interfaces.Card_Interfaces;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Effects._Base;

namespace MTG.Model.Effects
{
    public class ConvertToCardEffect : Effect
    {
        #region Properties
        public ICard NewCard { get; private set; }
        #endregion

        #region Constructors
        public ConvertToCardEffect(ITarget target, ICard newCard) : base(target)
        {
            Assign(target);
            NewCard = newCard;
        }
        #endregion
    }
}
