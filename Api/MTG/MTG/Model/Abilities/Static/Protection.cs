using MTG.Enumerations;
using MTG.Model.Abilities._Base;
using System.Collections.Generic;

namespace MTG.Model.Abilities.Static
{
    public class Protection:StaticAbility
    {
        #region Variables
        private List<Color> _Colors;
        private List<SubType> _SubTypes;
        private List<CardType> _CardTypes;
        #endregion

        #region Collection Properties
        public IReadOnlyCollection<CardType> CardTypes { get { return _CardTypes.AsReadOnly(); } }
        public IReadOnlyCollection<Color> Colors { get { return _Colors.AsReadOnly(); } }
        public IReadOnlyCollection<SubType> SubTypes { get { return _SubTypes.AsReadOnly(); } }
        #endregion

        #region Methods
        public void Add(Color color)
        {
            _Colors.Add(color);
        }
        public void Add(SubType subType)
        {
            _SubTypes.Add(subType);
        }
        public void Add(CardType cardType)
        {
            _CardTypes.Add(cardType);
        }
        public void Remove(Color color)
        {
            _Colors.Remove(color);
        }
        public void Remove(SubType subType)
        {
            _SubTypes.Remove(subType);
        }
        public void Remove(CardType cardType)
        {
            _CardTypes.Remove(cardType);
        }
        public override string ToString()
        {
            return this.GetType().Name;
        }
        #endregion

        #region Factory Methods
        public static Protection From(List<Color> colors)
        {
            return From(colors, new List<CardType>(), new List<SubType>());
        }
        public static Protection From(List<SubType> subTypes)
        {
            return From(new List<Color>(), new List<CardType>(), subTypes);
        }
        public static Protection From(List<CardType> cardTypes)
        {
            return From(new List<Color>(), cardTypes, new List<SubType>());
        }
        public static Protection From(List<Color> colors, List<CardType> cardTypes, List<SubType> subTypes)
        {
            Protection retVal = new Protection();
            foreach (Color color in colors)
                retVal.Add(color);
            foreach (CardType cardType in cardTypes)
                retVal.Add(cardType);
            foreach (SubType subType in subTypes)
                retVal.Add(subType);
            return retVal;
        }
        #endregion
    }
}
