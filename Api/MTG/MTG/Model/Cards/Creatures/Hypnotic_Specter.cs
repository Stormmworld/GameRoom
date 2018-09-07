using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Interfaces.Data_Interfaces;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;
using MTG.Model.Abilities.Static;

namespace MTG.Model.Cards
{
    public class Hypnotic_Specter : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=68
        *  
        *  Flying
        *  Whenever Hypnotic Specter deals damage to an opponent, that player discards a card at random.
        *  
        * Rulings
        * 2008-08-01: The ability triggers even if the Specter's damage is being redirected to an opponent. It does not trigger if damage that would have been dealt to the opponent is redirected to a nonopponent player or a creature, or if the damage is prevented.
        *
        */
        #region Constructors
        public Hypnotic_Specter() : base()
        {
            MultiverseId = 68;
            Name = "Hypnotic Specter";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Specter);
            Add(CardType.Creature);
            Add(new Flying());
        }
        public Hypnotic_Specter(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
        #endregion

        #region Methods
        public override IDamage CreateCombatDamage()
        {
            Damage damage = (Damage)base.CreateCombatDamage();
            damage.OnDamageOpponent = true;
            damage.OnDamagePlayerEffect = new DiscardEffect(1,true);
            return damage;
        }
        #endregion
    }
}