using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System.Linq;

namespace MTG.Model.Cards
{
    public class Keldon_Warlord : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=208
        *  
        *  Keldon Warlord's power and toughness are each equal to the number of non-Wall creatures you control.
        *  
        * Rulings
        * 2008-08-01: This is a Characteristic-Defining Ability. It checks the number of non-Wall creatures you control continuously, and applies in all zones. It is never "locked in".
        *
        */
        #region Properties
        public override int Power
        {
            get
            {
                int retVal = base.Power;
                retVal -= Controller.BattleField.Find(o => o.SubTypes.Contains(SubType.Wall)).Count;
                return retVal;
            }
        }
        public override int Toughness
        {
            get
            {
                int retVal = base.Toughness;
                retVal -= Controller.BattleField.Find(o => o.SubTypes.Contains(SubType.Wall)).Count;
                return retVal;
            }
        }
        #endregion

        #region Constructors
        public Keldon_Warlord() : base()
        {
            MultiverseId = 208;
            Name = "Keldon Warlord";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Human);
            Add(SubType.Barbarian);
            Add(CardType.Creature);
            PowerModifier = Modifier.TypeControllerControls;
            ToughnessModifier = Modifier.TypeControllerControls;
        }
        public Keldon_Warlord(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
        #endregion
    }
}
