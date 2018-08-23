using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Chaoslace : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=187
            *  
            *  Target spell or permanent becomes red. (Its mana symbols remain unchanged.)
            *  
            * Rulings

            *  
            */
        public Chaoslace() : base()
        {
            MultiverseId = 187;
            Name = "Chaoslace";
	Add(Enumerations.Colors.Red);
	Add(Enumerations.CardType.Instant);

            throw new NotImplementedException("Chaoslace");
        }
        public Chaoslace(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
