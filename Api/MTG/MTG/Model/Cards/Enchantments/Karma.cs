using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Karma : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=257
        *  
        *  At the beginning of each player's upkeep, Karma deals damage to that player equal to the number of Swamps he or she controls.
        *  
        * Rulings
        * 2004-10-04: Amount of damage is determined when the ability resolves and not when it is placed on the stack.
        *
        */
        public Karma() : base()
        {
            MultiverseId = 257;
            Name = "Karma";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.White, 1)));
            Add(Color.White);
            Add(CardType.Enchantment);
            TargetRequirements targetRequirements = new TargetRequirements(TargetScope.ActivePlayer, TargetType.Player);
            Damage damage = new Damage(this, Modifier.Controlled_Swamp);
            Add(new UpkeepDamage(targetRequirements, damage, TargetScope.All));
        }
        public Karma(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
