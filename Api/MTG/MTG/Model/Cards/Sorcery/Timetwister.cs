using MTG.Interfaces.Ability_Interfaces;
using MTG.Model.Abilities.Spell;
using MTG.Model.Objects;

namespace MTG.Model.Cards.Sorcery
{
    public class Timetwister : Card
    {
        /*
         * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=427
         * Each player shuffles their hand and graveyard into their library, then draws seven cards. 
         * (Then put Timetwister into its owner's graveyard.)
         * 
         * Rulings
         * This card won’t be put into your graveyard until after it’s finished resolving, which 
         * means it won’t be shuffled into your library as part of its own effect.
         */
        public Timetwister() : base()
        {
            CastingCost castingCost = new CastingCost();
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Blue, Count = 1 } });
            castingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 2 } });
            ICastingAbility ability = new CombineGraveyardAndHandToLibraryThenDraw(7, Enumerations.TargetScope.All, new System.Collections.Generic.List<Enumerations.TargetType>() { Enumerations.TargetType.Player }, false, castingCost, this);

            MultiverseId = 427;
            Name = "Timetwister";
            Add(Enumerations.CardType.Sorcery);
            Add(Enumerations.Colors.Blue);
        }
        public Timetwister(int multiversId):this()
        {
            MultiverseId = multiversId;
        }
    }
}
