using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using System;

namespace MTG.Model.Cards
{
    public class Drudge_Skeletons : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=62
        *  
        *  {B}: Regenerate Drudge Skeletons. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)
        *  
        * Rulings

        *
        */
        public Drudge_Skeletons() : base()
        {
            MultiverseId = 62;
            Name = "Drudge Skeletons";
            Set(1, 1);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 1)));
            CastingCost.Add(new ManaCost(new Mana(Color.Black, 1)));
            Add(Color.Black);
            Add(SubType.Skeleton);
            Add(CardType.Creature);

            throw new NotImplementedException("Drudge Skeletons");
        }
        public Drudge_Skeletons(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
