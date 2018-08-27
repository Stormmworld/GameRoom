using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Nevinyrrals_Disk : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=37
        *  
        *  Nevinyrral's Disk enters the battlefield tapped.
{1}, {T}: Destroy all artifacts, creatures, and enchantments.
        *  
        * Rulings
        * 2016-06-08: You don't sacrifice Nevinyrral's Disk to activate its ability. It's destroyed as part of the ability's resolution if it's still on the battlefield. If an effect gives Nevinyrral's Disk indestructible or regenerates it, it stays on the battlefield.

        *
        */
        public Nevinyrrals_Disk() : base()
        {
            MultiverseId = 37;
            Name = "Nevinyrral's Disk";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            Add(CardType.Artifact);

            throw new NotImplementedException("Nevinyrral's Disk");
        }
        public Nevinyrrals_Disk(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
