using MTG.Enumerations;
using MTG.Model.Abilities;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Badlands : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=279
            *  
            *  T: Add Black or Red
            *  
            * Rulings
            *  Land type changing effects that change a dual land’s land type will remove the old land types completely. Text-changing effects that just change one of the two land types will leave the other type unaffected.
            *  
            */
        public Badlands() : base()
        {
            MultiverseId = 279;
            Name = "Badlands";
            Add(CardType.Land);
            Add(SubType.Swamp);
            Add(SubType.Mountian);
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Red, Count = 1 }) { RequiresTap = true });
            Add(new ManaSource(new Mana() { Color = Enumerations.Colors.Black, Count = 1 }) { RequiresTap = true });
        }
        public Badlands(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
