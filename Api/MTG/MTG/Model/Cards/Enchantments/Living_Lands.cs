using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Static;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Living_Lands : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=165
        *  
        *  All Forests are 1/1 creatures that are still lands.
        *  
        * Rulings
        * 2008-08-01: A noncreature permanent that turns into a creature can attack, and its {T} abilities can be activated, only if its controller has continuously controlled that permanent since the beginning of his or her most recent turn. It doesn't matter how long the permanent has been a creature.
        *
        */
        public Living_Lands() : base()
        {
            MultiverseId = 165;
            Name = "Living Lands";
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Green, 1)));
            Add(Color.Green);
            Add(CardType.Enchantment);
            Add(new AbilityGeneratorStatic(new ConvertToCreature(1, 1) { BoundCardId = Id }, new TargetRequirements(TargetScope.All, TargetType.Card, new TargetCardRequirements() { HasType= CardType.Land, HasSubType= SubType.Forest, InZone= TargetZone.Battlefield})));
        }
        public Living_Lands(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
