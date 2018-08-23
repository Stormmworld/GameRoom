using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;
using System;

namespace MTG.Model.Cards
{
    public class Time_Vault : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=45
            *  
            *  Time Vault enters the battlefield tapped.
Time Vault doesn't untap during your untap step.
If you would begin your turn while Time Vault is tapped, you may skip that turn instead. If you do, untap Time Vault.
{T}: Take an extra turn after this one.
            *  
            * Rulings
		2004-10-04: If multiple "extra turn" effects resolve in the same turn, take them in the reverse of the order that the effects resolved.
		2008-10-01: The choice of whether or not to skip a turn is made as that turn would begin, and only if Time Vault is tapped at that time. If you choose to skip your turn, Time Vault untaps before anything else happens in the next turn.
		2008-10-01: This wording means that you no longer end up skipping multiple turns if you find a way to activate the ability multiple times.

            *  
            */
        public Time_Vault() : base()
        {
            MultiverseId = 45;
            Name = "Time Vault";
	Add(Enumerations.CardType.Artifact);

            throw new NotImplementedException("Time Vault");
        }
        public Time_Vault(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
