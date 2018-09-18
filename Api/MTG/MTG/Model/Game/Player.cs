using MTG.Interfaces.Data_Interfaces;
using MTG.Interfaces.Effect_Interfaces;
using MTG.Model.Zones;
using System;
using System.Collections.Generic;

namespace MTG.Model.Game
{
    public class Player
    {
        #region Variables
        private List<ICounter> _Counters;
        private List<IEffect> _Effects;
        #endregion

        #region Collection Properties
        public IReadOnlyList<ICounter> Counters { get { return _Counters.AsReadOnly(); } }
        public IReadOnlyList<IEffect> Effects { get { return _Effects.AsReadOnly(); } }
        #endregion

        #region Properties
        public Guid Id { get; private set; }
        public BattleField BattleField { get; private set; }
        public Exile Exile { get; private set; }
        public Hand Hand { get; private set; }
        public Library Library { get; private set; }
        public int Life { get; internal set; }
        public string Name { get; set; }
        public string SocketId { get; set; }
        #endregion

        #region Constructors
        public Player()
        {
            _Counters = new List<ICounter>();
            _Effects = new List<IEffect>();
            BattleField = new BattleField();
            Exile = new Exile();
            Hand = new Hand();
            Library = new Library();
            Id = Guid.NewGuid();
        }
        #endregion

        #region Event Handlers
        #endregion

        #region Methods
        public void Add(ICounter counter)
        {
            throw new NotImplementedException("Player.Add ICounter");
        }
        public void Add(IEffect effect)
        {
            throw new NotImplementedException("Player.Add IEffect");
        }
        public void Draw()
        {
            Draw(1);
        }
        public void Draw(int drawCount)
        {
            Hand.Add(Library.Draw(drawCount));
        }
        public void Remove(ICounter counter)
        {
            throw new NotImplementedException("Player.Remove ICounter");
        }
        public void Remove(IEffect effect)
        {
            throw new NotImplementedException("Player.Remove IEffect");
        }
        #endregion
    }
}
