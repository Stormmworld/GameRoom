using MTG.Model.Abilities.Triggered;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Black_Vise : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=4
            *  
            *  As Black Vise enters the battlefield, choose an opponent.
                At the beginning of the chosen player's upkeep, Black Vise deals X damage to that player, where X is the number of cards in his or her hand minus 4.
            *  
            * Rulings
		        2004-10-04: You choose one opposing player as it enters the battlefield and it only affects that one player. This choice is not changed even if Black Vise changes controllers. It becomes useless but stays on the battlefield if that player leaves the game.
		        2009-10-01: If the chosen player has four or fewer cards in his or her hand as Black Vise's ability resolves, the ability just won't do anything that turn.
            *  
            */
        public Black_Vise() : base()
        {
            MultiverseId = 4;
            Name = "Black Vise";
            Add(Enumerations.CardType.Artifact);
            Add(new AbilityGenerator(Enumerations.EffectTrigger.Card_EntersBattleField, new HandSizeDamage(Enumerations.EffectTrigger.Phases_BegginingPhase_UpkeepStep, 4, Enumerations.Comparator.Greater_Than, 1, Id), Enumerations.TargetScope.Single, Enumerations.TargetType.Player));
        }
        public Black_Vise(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
