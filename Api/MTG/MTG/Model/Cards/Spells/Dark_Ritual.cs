using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Casting;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;

namespace MTG.Model.Cards
{
    public class Dark_Ritual : Spell
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=54
        *  
        *  Add {B}{B}{B} to your mana pool.
        *  
        * Rulings

        *
        */
        public Dark_Ritual() : base()
        {
            MultiverseId = 54;
            Name = "Dark Ritual";
            CastingCost abilityCost = new CastingCost();
            abilityCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(CardType.Instant);
            Add(new AddManaToPool(abilityCost,new List<IMana>() { new Mana(Color.Black, 3) } , false));
        }
        public Dark_Ritual(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
