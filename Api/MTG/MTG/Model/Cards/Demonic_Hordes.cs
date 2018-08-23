using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Demonic_Hordes : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=59
            *  
            *  {T}: Destroy target land.
At the beginning of your upkeep, unless you pay {B}{B}{B}, tap Demonic Hordes and sacrifice a land of an opponent's choice.
            *  
            * Rulings

            *  
            */
        public Demonic_Hordes() : base()
        {
            MultiverseId = 59;
            Name = "Demonic Hordes";
	Add(Enumerations.Colors.Black);
	Add(Enumerations.SubType.Demon);
	Add(Enumerations.CardType.Creature);
	_Power = 5;
		_Toughness = 5;

            throw new NotImplementedException("Demonic Hordes");
        }
        public Demonic_Hordes(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
