using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Game;
using MTG.Model.Abilities.Activated;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Gaeas_Liege : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=152
        *  
        *  As long as Gaea's Liege isn't attacking, its power and toughness are each equal to the number of Forests you control. As long as Gaea's Liege is attacking, its power and toughness are each equal to the number of Forests defending player controls.
        *  {T}: Target land becomes a Forest until Gaea's Liege leaves the battlefield.
        *  
        * Rulings
        * 2004-10-04: When being declared as an attacker, use the "not attacking" power and toughness. It only changes after declaration is complete.
        * 2006-09-25: The activated ability doesn't affect whether the land is basic or not. It overwrites any other land types. Being a Forest gives the affected land the ability "{T}: Add {G} to your mana pool."
        * 2006-10-15: Will not add or remove Snow Supertype to or from a land.
        *
        */
        public Gaeas_Liege() : base()
        {
            MultiverseId = 152;
            Name = "Gaea's Liege";
            //Set(*,*);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(SubType.Avatar);
            Add(CardType.Creature);
            PowerModifier = Modifier.SubTypeControllerControls;
            ToughnessModifier = Modifier.SubTypeControllerControls;
            Add(new EffectGenerator(true, typeof(CardSubTypeModificationEffect), new TargetRequirements(TargetScope.Single, TargetType.Card, new TargetCardRequirements() { HasType = CardType.Land, InZone = TargetZone.Battlefield }), GamePhase.None) { BoundCardId = Id, Card = new Forest() });
        }
        public Gaeas_Liege(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }

        #region Methods
        public override void Attack(ref Player defendingPlayer)
        {
            base.Attack(ref defendingPlayer);
            ToughnessModifier = Modifier.SubTypeDefenderControls;
            ToughnessModifier = Modifier.SubTypeDefenderControls;
        }
        public override void EndCombat()
        {
            ToughnessModifier = Modifier.SubTypeControllerControls;
            ToughnessModifier = Modifier.SubTypeControllerControls;
            base.EndCombat();
        }
        #endregion
    }
}