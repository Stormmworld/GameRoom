using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using MTG.Model.Effects;

namespace MTG.Model.Cards
{
    public class Demonic_Tutor : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=60
        *  
        *  Search your library for a card and put that card into your hand. Then shuffle your library.
        *  
        * Rulings
        * 2004-10-04: You pick a card on resolution.
        * 2004-10-04: You don't reveal the card to your opponent.
        * 2004-10-04: This card is put directly into your hand. It is not drawn.

        *
        */
        public Demonic_Tutor() : base()
        {
            MultiverseId = 60;
            Name = "Demonic Tutor";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Sorcery);
            Add(new CreateEffect(abilityCost, new TargetRequirements(TargetScope.Self, TargetType.Player ), typeof(FindCardEffect), false));
        }
        public Demonic_Tutor(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
