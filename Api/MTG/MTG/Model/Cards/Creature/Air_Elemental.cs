using MTG.Model.Abilities.Static;
using MTG.Model.Objects;

namespace MTG.Model.Cards
{
    public class Air_Elemental : Card
    {
        /*
            * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=94
            *  
            *  Flying
            *  
            * Rulings

            *  
            */
        public Air_Elemental() : base()
        {
            MultiverseId = 94;
            Name = "Air Elemental";
            Add(Enumerations.Colors.Blue);
            Add(Enumerations.SubType.Elemental);
            Add(Enumerations.CardType.Creature);
            Add(new Flying());
            _Power = 4;
            _Toughness = 4;
        }
        public Air_Elemental(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
