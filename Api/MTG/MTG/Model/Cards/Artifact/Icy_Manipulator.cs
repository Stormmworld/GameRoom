using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Icy_Manipulator : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=19
            *  
            *  {1}, {T}: Tap target artifact, creature, or land.
            *  
            * Rulings
		        2004-10-04: Tapping a card with an effect like this will never pay the cost of an ability. For example, tapping a land with this card will not put mana into a player's pool.
		        2004-10-04: Icy Manipulator can't be used to stop someone from using an ability of the permanent you plan to tap. It can be used to make a player use the ability now or to not use it.
		        2004-10-04: The ability can target a tapped card, but tapping a tapped card does nothing useful. And it will not trigger "if the card becomes tapped" effects.
		        2004-10-04: If you want to stop someone from attacking with a creature by using this card, you must do so before attackers are declared. You can't wait until after attackers are declared and then try to use it to make a creature stop attacking. Note that your opponent can't start declaring attackers without letting you use the Icy Manipulator.
		        2004-10-04: Tapping an attacking creature which did not tap to attack does not remove the creature from the attack or cause the creature to stop dealing damage.
            *  
            */
        public Icy_Manipulator() : base()
        {
            MultiverseId = 19;
            Name = "Icy Manipulator";
            Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Icy Manipulator");
        }
        public Icy_Manipulator(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
