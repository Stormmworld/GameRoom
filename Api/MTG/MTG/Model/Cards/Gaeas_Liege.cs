using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Gaeas_Liege : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=152
            *  
            *  As long as Gaea's Liege isn't attacking, its power and toughness are each equal to the number of Forests you control. As long as Gaea's Liege is attacking, its power and toughness are each equal to the number of Forests defending player controls.
                {T}: Target land becomes a Forest until Gaea's Liege leaves the battlefield.
            *  
            * Rulings
		        2004-10-04: When being declared as an attacker, use the "not attacking" power and toughness. It only changes after declaration is complete.
		        2006-09-25: The activated ability doesn't affect whether the land is basic or not. It overwrites any other land types. Being a Forest gives the affected land the ability "{T}: Add {G} to your mana pool."
		        2006-10-15: Will not add or remove Snow Supertype to or from a land.

            *  
            */
        public Gaeas_Liege() : base()
        {
            MultiverseId = 152;
            Name = "Gaea's Liege";
            Add(Enumerations.Colors.Green);
            Add(Enumerations.SubType.Avatar);
            Add(Enumerations.CardType.Creature);
            //_Power = *;
            //	_Toughness = *;

            throw new NotImplementedException("Gaea's Liege");
        }
        public Gaeas_Liege(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}