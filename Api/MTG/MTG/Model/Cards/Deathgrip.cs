using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Deathgrip : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=56
            *  
            *  {B}{B}: Counter target green spell.
            *  
            * Rulings

            *  
            */
        public Deathgrip() : base()
        {
            MultiverseId = 56;
            Name = "Deathgrip";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.CardType.Enchantment);

            throw new NotImplementedException("Deathgrip");
        }
        public Deathgrip(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
