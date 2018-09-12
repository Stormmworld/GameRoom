using MTG.Enumerations;
using MTG.Model.Mana_Objects;
using MTG.Model.Cards._Base;
using MTG.Model.Abilities.Activated;
using System.Collections.Generic;
using MTG.Interfaces.Mana_Interfaces;
using MTG.Model.Effects;
using MTG.Model.Data_Objects;

namespace MTG.Model.Cards
{
    public class Uthden_Troll : Creature
        {
        /*
        * http://gatherer.wizards.com/Pages/Card/Details.aspx?multiverseid=228
        *  
        *  {R}: Regenerate Uthden Troll.
        *  
        * Rulings
        *
        */
        public Uthden_Troll() : base()
        {
            MultiverseId = 228;
            Name = "Uthden Troll";
            Set(2, 2);
            CastingCost.Add(new ManaCost(new Mana(Color.Colorless, 2)));
            CastingCost.Add(new ManaCost(new Mana(Color.Red, 1)));
            Add(Color.Red);
            Add(SubType.Troll);
            Add(CardType.Creature);
            Add(new EffectGenerator(false, new List<IManaCost>() { new ManaCost(new Mana(Color.Red, 1)) }, typeof(RegenerationEffect), new TargetRequirements(TargetScope.Self, TargetType.None), GamePhase.None));
        }
        public Uthden_Troll(int multiversId) : this()
        {
            MultiverseId = multiversId;
        }
    }
}
