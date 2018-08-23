using MTG.Enumerations;
using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Bog_Wraith : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=51
            *  
            *  Swampwalk (This creature can't be blocked as long as defending player controls a Swamp.)
            *  
            * Rulings

            *  
            */
        public Bog_Wraith() : base()
        {
            MultiverseId = 51;
            Name = "Bog Wraith";
            _Power = 3;
            _Toughness = 3;
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Black, Count = 1 } });
            CastingCost.ManaCosts.Add(new ManaCost() { Cost = new Mana() { Color = Enumerations.Colors.Colorless, Count = 3 } });
            Add(Enumerations.Colors.Black);
            Add(SubType.Wraith);
            Add(CardType.Creature);
            Add(new Landwalk(SubType.Swamp));
        }
        public Bog_Wraith(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
