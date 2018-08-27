using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Mana_Objects
{
    public class CastingCost : ICastingCost
    {
        #region Collection Properties
        private List<IManaCost> _ManaCosts;
        #endregion

        #region Collection Properties
        public IReadOnlyList<IManaCost> ManaCosts { get { return _ManaCosts.AsReadOnly(); } }
        #endregion

        #region Properties
        public int XCost { get; private set; }
        #endregion

        #region Constructors
        public CastingCost()
        {
            _ManaCosts = new List<IManaCost>();
        }
        public CastingCost(List<IManaCost> manaCosts) : this()
        {
            _ManaCosts.AddRange(manaCosts);
        }
        public CastingCost(List<IManaCost> manaCosts, int xCost) :this(manaCosts)
        {
            XCost = xCost;
        }
        public CastingCost( int xCost) : this()
        {
            XCost = xCost;
        }
        #endregion

        #region Methods
        public void Add(int x)
        {
            XCost += x;
        }
        public void Add(IManaCost manaCost)
        {
            _ManaCosts.Add(manaCost);
        }
        public void Add(List<IManaCost> manaCosts)
        {
            _ManaCosts.AddRange(manaCosts);
        }
        public void Remove(int x)
        {
            XCost -= x;
        }
        public void Remove(IManaCost manaCost)
        {
            _ManaCosts.Remove(manaCost);
        }
        #endregion
    }
}
