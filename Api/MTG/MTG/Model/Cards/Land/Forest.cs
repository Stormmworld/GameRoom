using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;

namespace MTG.Model.Cards
{
    public class Forest : Permanent
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=288
        *  
        *  
        *  
        * Rulings

        *
        */
        public Forest() : base()
        {
            MultiverseId = 288;
            Name = "Forest";
            Add(SubType.Forest);
            Add(CardType.Land);
            Add(SuperType.Basic);
            Add(new ManaSource(true, new List<Mana>() { new Mana(Color.Green, 1) }));
        }
        public Forest(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
