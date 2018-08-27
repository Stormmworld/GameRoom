using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Demonic_Hordes : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=59
        *  
        *  {T}: Destroy target land.
At the beginning of your upkeep, unless you pay {B}{B}{B}, tap Demonic Hordes and sacrifice a land of an opponent's choice.
        *  
        * Rulings

        *
        */
        public Demonic_Hordes() : base()
        {
            MultiverseId = 59;
            Name = "Demonic Hordes";
            Set(5, 5);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 3)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Demon);
            Add(CardType.Creature);

            throw new NotImplementedException("Demonic Hordes");
        }
        public Demonic_Hordes(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
