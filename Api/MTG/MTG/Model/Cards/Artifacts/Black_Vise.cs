using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Black_Vise : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=4
        *  
        *  As Black Vise enters the battlefield, choose an opponent.
        *  At the beginning of the chosen player's upkeep, Black Vise deals X damage to that player, where X is the number of cards in his or her hand minus 4.
        *  
        * Rulings
        * 2004-10-04: You choose one opposing player as it enters the battlefield and it only affects that one player. This choice is not changed even if Black Vise changes controllers. It becomes useless but stays on the battlefield if that player leaves the game.
        * 2009-10-01: If the chosen player has four or fewer cards in his or her hand as Black Vise's ability resolves, the ability just won't do anything that turn.
        *
        */
        public Black_Vise() : base()
        {
            MultiverseId = 4;
            Name = "Black Vise";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            Add(CardType.Artifact);
            Add(new HandSizeRequirement(EffectTrigger.Phases_BegginingPhase_UpkeepStep, 4, Comparator.Greater_Than, ActionType.Damage, 1));
        }
        public Black_Vise(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
