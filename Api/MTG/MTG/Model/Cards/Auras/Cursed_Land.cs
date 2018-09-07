using System.Collections.Generic;
using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Data_Objects;
using MTG.Model.Abilities.Triggered;

namespace MTG.Model.Cards
{
    public class Cursed_Land : Aura
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=53
        *  
        *  Enchant land
        *  At the beginning of the upkeep of enchanted land's controller, Cursed Land deals 1 damage to that player.
        *  
        * Rulings
        *
        */
        public Cursed_Land() :  base(new TargetCardRequirements() { HasType = CardType.Land , InZone = TargetZone.Battlefield })
        {
            MultiverseId = 53;
            Name = "Cursed Land";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Aura);
            Add(CardType.Enchantment);
            Add(new UpkeepDamage(new TargetRequirements(TargetScope.Controller,TargetType.Player), new Damage(this,1)));
        }
        public Cursed_Land(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}