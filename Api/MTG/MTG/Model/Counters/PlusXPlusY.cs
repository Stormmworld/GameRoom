using MTG.Enumerations;
using MTG.Model.Counters._Base;

namespace MTG.Model.Counters
{
    public class PlusXPlusY : Counter
    {
        #region Properties
        public bool UseXValue { get; internal set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        #endregion

        #region Constructors
        public PlusXPlusY(int x, int y):base()
        {
            X = x;
            Y = y;
        }
        public PlusXPlusY(Incrementer x, Incrementer y):base()
        {

        }
        #endregion
    }
}
