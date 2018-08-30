using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using MTG.Model.Data_Objects;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Braingeyser : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=98
        *  
        *  Target player draws X cards.
        *  
        * Rulings

        *
        */
        public Braingeyser() : base()
        {
            MultiverseId = 98;
            Name = "Braingeyser";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless, true)));
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1)));;
            abilityCost.Add(new ManaCost(new Mana(Color.Blue, 1))); ;
            abilityCost.Add(new ManaCost(new Mana(Color.Colorless,true))); ;
            Add(Color.Blue);
            Add(CardType.Sorcery);
            Add(new DrawCards(true, abilityCost, new TargetRequirements(TargetScope.Single, new List<TargetType>() { TargetType.Player }),false));
        }
        public Braingeyser(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
