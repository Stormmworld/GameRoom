using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Triggered;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Lord_of_the_Pit : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=70
        *  
        *  Flying, trample
        *  At the beginning of your upkeep, sacrifice a creature other than Lord of the Pit. If you can't, Lord of the Pit deals 7 damage to you.
        *  
        * Rulings
        * 2017-11-17: If you control any other creatures as Lord of the Pit's triggered ability resolves, you must sacrifice one. You can't choose to be dealt 7 damage instead.
        * 2017-11-17: If Lord of the Pit has gained lifelink, being dealt 7 damage by it doesn't cause your life total to change, even though you gain and lose life. If your life total is less than 7, you won't lose the game.
        * 2017-11-17: If you have two Lords of the Pit, you can sacrifice them to each other.
        *
        */
        public Lord_of_the_Pit() : base()
        {
            MultiverseId = 70;
            Name = "Lord of the Pit";
            Set(7, 7);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 4)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Demon);
            Add(CardType.Creature);
            Add(new UpkeepSacrifice(new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Creature, InZone = TargetZone.Battlefield }), false) { FailedEffect = new FailedUpkeepResult(new TargetRequirements(TargetScope.Controller, TargetType.Player), typeof(DamageEffect), new Damage(this, 7)) });
        }
        public Lord_of_the_Pit(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
